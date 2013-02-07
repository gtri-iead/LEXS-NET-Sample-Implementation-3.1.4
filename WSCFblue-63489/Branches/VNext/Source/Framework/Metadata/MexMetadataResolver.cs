﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace Thinktecture.Wscf.Framework.Metadata
{
	/// <summary>
	/// Resolves metadata from MEX and HTTP GET endpoints.
	/// </summary>
	public class MexMetadataResolver : IMexMetadataResolver
	{
		private const int metadataExchangeClientTimeoutMinutes = 5;
		private const int maxReceivedMessageSize = 67108864;

		/// <summary>
		/// Resolves metadata from the specified endpoint reference.
		/// </summary>
		/// <param name="endpointReference">The endpoint reference.</param>
		/// <returns>A list of metadata sections.</returns>
		public IEnumerable<MetadataSection> Resolve(EndpointAddress endpointReference)
		{
			return Resolve(endpointReference, false);
		}

		/// <summary>
		/// Resolves metadata from the specified service URI.
		/// </summary>
		/// <param name="serviceUri">The service URI.</param>
		/// <returns>A list of metadata sections.</returns>
		public IEnumerable<MetadataSection> Resolve(Uri serviceUri)
		{
			Uri defaultMexUri = GetDefaultMexUri(serviceUri);
			bool supportsDisco = UriSchemeSupportsDisco(serviceUri);

			Task<Tuple<bool, IEnumerable<MetadataSection>, MetadataDiscoveryException>> mexTask = 
				Task.Factory.StartNew(() => TryResolveMetadata(serviceUri, false));
			Task<Tuple<bool, IEnumerable<MetadataSection>, MetadataDiscoveryException>> defaultMexTask = 
				Task.Factory.StartNew(() => TryResolveMetadata(defaultMexUri, false));
			Task<Tuple<bool, IEnumerable<MetadataSection>, MetadataDiscoveryException>> httpGetTask = null;
			if (supportsDisco)
			{
				httpGetTask = Task.Factory.StartNew(() => TryResolveMetadata(serviceUri, true));
			}

			if (mexTask.Result.Item1)
			{
				return mexTask.Result.Item2;
			}
			if (defaultMexTask.Result.Item1)
			{
				return defaultMexTask.Result.Item2;
			}
			if (httpGetTask != null && httpGetTask.Result.Item1)
			{
				return httpGetTask.Result.Item2;
			}

			Exception mexInnerException = mexTask.Result.Item3.InnerException;
			Exception defaultMexInnerException = defaultMexTask.Result.Item3.InnerException;

			if ((mexInnerException is EndpointNotFoundException) && (defaultMexInnerException is EndpointNotFoundException))
			{
				string message = string.Format("Cannot obtain Metadata from the URI: {0}\r\nCheck the URI and try again.", serviceUri.AbsoluteUri);
				throw new MetadataDiscoveryException(message);
			}
			throw new MexMetadataDiscoveryException(mexTask.Result.Item3, (httpGetTask == null) ? null : httpGetTask.Result.Item3, serviceUri);
		}

		private static Tuple<bool,IEnumerable<MetadataSection>,MetadataDiscoveryException> TryResolveMetadata(Uri uri, bool useDisco)
		{
			try
			{
				IEnumerable<MetadataSection> resolvedMetadata = Resolve(new EndpointAddress(uri, new AddressHeader[0]), useDisco);
				return Tuple.Create<bool,IEnumerable<MetadataSection>,MetadataDiscoveryException>(true, resolvedMetadata, null);
			}
			catch (MetadataDiscoveryException exception)
			{
				return Tuple.Create<bool, IEnumerable<MetadataSection>, MetadataDiscoveryException>(false, null, exception);
			}
		}

		private static IEnumerable<MetadataSection> Resolve(EndpointAddress endpointReference, bool useDisco)
		{
			MetadataSet metadata;
			try
			{
				if (useDisco)
				{
					return DiscoveryMetadataResolver.Resolve(endpointReference.Uri.AbsoluteUri);
				}
				MetadataExchangeClient client = CreateMetadataExchangeClient(endpointReference);
				client.OperationTimeout = TimeSpan.FromMinutes(metadataExchangeClientTimeoutMinutes);
				metadata = client.GetMetadata(endpointReference);
			}
			catch (Exception exception)
			{
				throw new MetadataDiscoveryException(exception.Message, exception);
			}
			return metadata.MetadataSections;
		}
		
		private static MetadataExchangeClient CreateMetadataExchangeClient(EndpointAddress endpointReference)
		{
			string scheme = endpointReference.Uri.Scheme;
			if (string.Compare(scheme, Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase) == 0)
			{
				WSHttpBinding mexHttpBinding = (WSHttpBinding)MetadataExchangeBindings.CreateMexHttpBinding();
				mexHttpBinding.MaxReceivedMessageSize = maxReceivedMessageSize;
				return new MetadataExchangeClient(mexHttpBinding);
			}
			if (string.Compare(scheme, Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase) == 0)
			{
				WSHttpBinding mexHttpsBinding = (WSHttpBinding)MetadataExchangeBindings.CreateMexHttpsBinding();
				mexHttpsBinding.MaxReceivedMessageSize = maxReceivedMessageSize;
				return new MetadataExchangeClient(mexHttpsBinding);
			}
			if (string.Compare(scheme, Uri.UriSchemeNetTcp, StringComparison.OrdinalIgnoreCase) == 0)
			{
				CustomBinding mexTcpBinding = (CustomBinding)MetadataExchangeBindings.CreateMexTcpBinding();
				mexTcpBinding.Elements.Find<TcpTransportBindingElement>().MaxReceivedMessageSize = maxReceivedMessageSize;
				return new MetadataExchangeClient(mexTcpBinding);
			}
			if (string.Compare(scheme, Uri.UriSchemeNetPipe, StringComparison.OrdinalIgnoreCase) != 0)
			{
				string message = string.Format("Cannot obtain Metadata from {0}. The URI scheme is not supported by default. Add a client endpoint in config with name=\"\" and contract=\"IMetadataExchange\" and an appropriate binding to obtain Metadata from this URI.", endpointReference.Uri.OriginalString);
				throw new ArgumentException(message);
			}
			CustomBinding mexNamedPipeBinding = (CustomBinding)MetadataExchangeBindings.CreateMexNamedPipeBinding();
			mexNamedPipeBinding.Elements.Find<NamedPipeTransportBindingElement>().MaxReceivedMessageSize = maxReceivedMessageSize;
			return new MetadataExchangeClient(mexNamedPipeBinding);
		}

		private static Uri GetDefaultMexUri(Uri serviceUri)
		{
			return serviceUri.AbsoluteUri.EndsWith("/", StringComparison.OrdinalIgnoreCase)
				? new Uri(serviceUri, "./mex")
				: new Uri(serviceUri.AbsoluteUri + "/mex");
		}

		private static bool UriSchemeSupportsDisco(Uri serviceUri)
		{
			return (serviceUri.Scheme == Uri.UriSchemeHttp || serviceUri.Scheme == Uri.UriSchemeHttps);
		}
	}
}
