using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.ServiceModel;
using System.Reflection;
using System.ServiceModel.Channels;


[DebuggerDisplay("Name={name}"), DebuggerDisplay("Address={address}")]
public class ServiceEndpoint
{
    // Fields
    private EndpointAddress address;
    private KeyedByTypeCollection<IEndpointBehavior> behaviors;
    private Binding binding;
    private ContractDescription contract;
    private string id;
    private Uri listenUri;
    private ListenUriMode listenUriMode;
    private XmlName name;

    // Methods
    public ServiceEndpoint(ContractDescription contract)
    {
        if (contract == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("contract");
        }
        this.contract = contract;
    }

    public ServiceEndpoint(ContractDescription contract, Binding binding, EndpointAddress address)
    {
        if (contract == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("contract");
        }
        this.contract = contract;
        this.binding = binding;
        this.address = address;
    }

    internal void EnsureInvariants()
    {
        if (this.Binding == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("AChannelServiceEndpointSBindingIsNull0")));
        }
        if (this.Contract == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("AChannelServiceEndpointSContractIsNull0")));
        }
        this.Contract.EnsureInvariants();
        this.Binding.EnsureInvariants(this.Contract.Name);
    }

    private void Validate(bool runOperationValidators, bool isForService)
    {
        ContractDescription contract = this.Contract;
        for (int i = 0; i < contract.Behaviors.Count; i++)
        {
            contract.Behaviors[i].Validate(contract, this);
        }
        if (!isForService)
        {
            ((IEndpointBehavior) PartialTrustValidationBehavior.Instance).Validate(this);
            ((IEndpointBehavior) PeerValidationBehavior.Instance).Validate(this);
            ((IEndpointBehavior) TransactionValidationBehavior.Instance).Validate(this);
            ((IEndpointBehavior) SecurityValidationBehavior.Instance).Validate(this);
            ((IEndpointBehavior) MsmqIntegrationValidationBehavior.Instance).Validate(this);
        }
        for (int j = 0; j < this.Behaviors.Count; j++)
        {
            this.Behaviors[j].Validate(this);
        }
        if (runOperationValidators)
        {
            for (int k = 0; k < contract.Operations.Count; k++)
            {
                OperationDescription operationDescription = contract.Operations[k];
                for (int m = 0; m < operationDescription.Behaviors.Count; m++)
                {
                    operationDescription.Behaviors[m].Validate(operationDescription);
                }
            }
        }
    }

    internal void ValidateForClient()
    {
        this.Validate(true, false);
    }

    internal void ValidateForService(bool runOperationValidators)
    {
        this.Validate(runOperationValidators, true);
    }

    // Properties
    public EndpointAddress Address
    {
        get
        {
            return this.address;
        }
        set
        {
            this.address = value;
        }
    }

    public KeyedByTypeCollection<IEndpointBehavior> Behaviors
    {
        get
        {
            if (this.behaviors == null)
            {
                this.behaviors = new KeyedByTypeCollection<IEndpointBehavior>();
            }
            return this.behaviors;
        }
    }

    public Binding Binding
    {
        get
        {
            return this.binding;
        }
        set
        {
            this.binding = value;
        }
    }

    public ContractDescription Contract
    {
        get
        {
            return this.contract;
        }
    }

    internal string Id
    {
        get
        {
            if (this.id == null)
            {
                this.id = Guid.NewGuid().ToString();
            }
            return this.id;
        }
    }

    public Uri ListenUri
    {
        get
        {
            if (this.listenUri != null)
            {
                return this.listenUri;
            }
            if (this.address == null)
            {
                return null;
            }
            return this.address.Uri;
        }
        set
        {
            if (value == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
            }
            if (!value.IsAbsoluteUri)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgument("value", SR.GetString("UriMustBeAbsolute"));
            }
            this.listenUri = value;
        }
    }

    public ListenUriMode ListenUriMode
    {
        get
        {
            return this.listenUriMode;
        }
        set
        {
            if (!ListenUriModeHelper.IsDefined(value))
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("value"));
            }
            this.listenUriMode = value;
        }
    }

    public string Name
    {
        get
        {
            if (!XmlName.IsNullOrEmpty(this.name))
            {
                return this.name.EncodedName;
            }
            if (this.binding != null)
            {
                return string.Format(CultureInfo.InvariantCulture, "{0}_{1}", new object[] { new XmlName(this.Binding.Name).EncodedName, this.Contract.Name });
            }
            return this.Contract.Name;
        }
        set
        {
            this.name = new XmlName(value, true);
        }
    }
}


