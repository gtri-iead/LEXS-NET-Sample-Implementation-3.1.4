﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Threading;
using System.Collections.ObjectModel;
using System.CodeDom;
using System.ServiceModel.Configuration;
using System.ServiceModel.Channels;


internal class ConfigWriter
{
    // Fields
    private readonly BindingsSection bindingsSection;
    private readonly Dictionary<Binding, BindingDictionaryValue> bindingTable = new Dictionary<Binding, BindingDictionaryValue>();
    private readonly ChannelEndpointElementCollection channels;
    private readonly System.Configuration.Configuration config;

    // Methods
    internal ConfigWriter(System.Configuration.Configuration configuration)
    {
        this.bindingsSection = BindingsSection.GetSection(configuration);
        ServiceModelSectionGroup sectionGroup = ServiceModelSectionGroup.GetSectionGroup(configuration);
        this.channels = sectionGroup.Client.Endpoints;
        this.config = configuration;
    }

    private bool CheckIfBindingNameInUse(string name, object nameCollection)
    {
        foreach (BindingCollectionElement element in this.bindingsSection.BindingCollections)
        {
            if (element.ContainsKey(name))
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckIfChannelNameInUse(string name, object namingCollection)
    {
        foreach (ChannelEndpointElement element in this.channels)
        {
            if (element.Name == name)
            {
                return true;
            }
        }
        return false;
    }

    private BindingDictionaryValue CreateBindingConfig(Binding binding)
    {
        BindingDictionaryValue value2;
        if (!this.bindingTable.TryGetValue(binding, out value2))
        {
            string str2;
            string name = NamingHelper.GetUniqueName(NamingHelper.CodeName(binding.Name), new NamingHelper.DoesNameExist(this.CheckIfBindingNameInUse), null);
            if (!BindingsSection.TryAdd(name, binding, this.config, out str2))
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(SR.GetString("ConfigBindingCannotBeConfigured"), "endpoint.Binding"));
            }
            value2 = new BindingDictionaryValue(name, str2);
            this.bindingTable.Add(binding, value2);
        }
        return value2;
    }

    internal void WriteBinding(Binding binding, out string bindingSectionName, out string configurationName)
    {
        BindingDictionaryValue value2 = this.CreateBindingConfig(binding);
        configurationName = value2.BindingName;
        bindingSectionName = value2.BindingSectionName;
    }

    internal ChannelEndpointElement WriteChannelDescription(ServiceEndpoint endpoint, string typeName)
    {
        ChannelEndpointElement element = null;
        BindingDictionaryValue value2 = this.CreateBindingConfig(endpoint.Binding);
        element = new ChannelEndpointElement(endpoint.Address, typeName);
        element.Name = NamingHelper.GetUniqueName(NamingHelper.CodeName(endpoint.Name), new NamingHelper.DoesNameExist(this.CheckIfChannelNameInUse), null);
        element.BindingConfiguration = value2.BindingName;
        element.Binding = value2.BindingSectionName;
        this.channels.Add(element);
        return element;
    }

    // Nested Types
    private sealed class BindingDictionaryValue
    {
        // Fields
        public readonly string BindingName;
        public readonly string BindingSectionName;

        // Methods
        public BindingDictionaryValue(string bindingName, string bindingSectionName)
        {
            this.BindingName = bindingName;
            this.BindingSectionName = bindingSectionName;
        }
    }
}

 
