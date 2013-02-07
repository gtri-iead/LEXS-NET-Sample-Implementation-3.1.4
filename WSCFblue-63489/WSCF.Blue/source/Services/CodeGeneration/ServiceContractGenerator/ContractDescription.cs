using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;
using System.Net.Security;
using System.Collections.ObjectModel;

[DebuggerDisplay("Name={name}, Namespace={ns}, ContractType={contractType}")]
public class ContractDescription
{
    // Fields
    private KeyedByTypeCollection<IContractBehavior> behaviors;
    private Type callbackContractType;
    private string configurationName;
    private Type contractType;
    private bool hasProtectionLevel;
    private XmlName name;
    private string ns;
    private OperationDescriptionCollection operations;
    private ProtectionLevel protectionLevel;
    private SessionMode sessionMode;

    // Methods
    public ContractDescription(string name) : this(name, null)
    {
    }

    public ContractDescription(string name, string ns)
    {
        this.behaviors = new KeyedByTypeCollection<IContractBehavior>();
        this.Name = name;
        if (!string.IsNullOrEmpty(ns))
        {
            NamingHelper.CheckUriParameter(ns, "ns");
        }
        this.operations = new OperationDescriptionCollection();
        this.ns = ns ?? "http://tempuri.org/";
    }

    internal void EnsureInvariants()
    {
        if (string.IsNullOrEmpty(this.Name))
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("AChannelServiceEndpointSContractSNameIsNull0")));
        }
        if (this.Namespace == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("AChannelServiceEndpointSContractSNamespace0")));
        }
        if (this.Operations.Count == 0)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("SFxContractHasZeroOperations", new object[] { this.Name })));
        }
        bool flag = false;
        for (int i = 0; i < this.Operations.Count; i++)
        {
            OperationDescription description = this.Operations[i];
            description.EnsureInvariants();
            if (description.IsInitiating)
            {
                flag = true;
            }
            if ((!description.IsInitiating || description.IsTerminating) && (this.SessionMode != SessionMode.Required))
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("ContractIsNotSelfConsistentItHasOneOrMore2", new object[] { this.Name })));
            }
        }
        if (!flag)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("SFxContractHasZeroInitiatingOperations", new object[] { this.Name })));
        }
    }

    public static ContractDescription GetContract(Type contractType)
    {
        if (contractType == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("contractType");
        }
        TypeLoader loader = new TypeLoader();
        return loader.LoadContractDescription(contractType);
    }

    public static ContractDescription GetContract(Type contractType, object serviceImplementation)
    {
        if (contractType == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("contractType");
        }
        if (serviceImplementation == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("serviceImplementation");
        }
        TypeLoader loader = new TypeLoader();
        Type serviceType = serviceImplementation.GetType();
        return loader.LoadContractDescription(contractType, serviceType, serviceImplementation);
    }

    public static ContractDescription GetContract(Type contractType, Type serviceType)
    {
        if (contractType == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("contractType");
        }
        if (serviceType == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("serviceType");
        }
        TypeLoader loader = new TypeLoader();
        return loader.LoadContractDescription(contractType, serviceType);
    }

    public Collection<ContractDescription> GetInheritedContracts()
    {
        Collection<ContractDescription> collection = new Collection<ContractDescription>();
        for (int i = 0; i < this.Operations.Count; i++)
        {
            OperationDescription description = this.Operations[i];
            if (description.DeclaringContract != this)
            {
                ContractDescription declaringContract = description.DeclaringContract;
                if (!collection.Contains(declaringContract))
                {
                    collection.Add(declaringContract);
                }
            }
        }
        return collection;
    }

    internal bool IsDuplex()
    {
        for (int i = 0; i < this.operations.Count; i++)
        {
            if (this.operations[i].IsServerInitiated())
            {
                return true;
            }
        }
        return false;
    }

    // Properties
    public KeyedByTypeCollection<IContractBehavior> Behaviors
    {
        get
        {
            return this.behaviors;
        }
    }

    public Type CallbackContractType
    {
        get
        {
            return this.callbackContractType;
        }
        set
        {
            this.callbackContractType = value;
        }
    }

    internal string CodeName
    {
        get
        {
            return this.name.DecodedName;
        }
    }

    public string ConfigurationName
    {
        get
        {
            return this.configurationName;
        }
        set
        {
            this.configurationName = value;
        }
    }

    public Type ContractType
    {
        get
        {
            return this.contractType;
        }
        set
        {
            this.contractType = value;
        }
    }

    public bool HasProtectionLevel
    {
        get
        {
            return this.hasProtectionLevel;
        }
    }

    public string Name
    {
        get
        {
            return this.name.EncodedName;
        }
        set
        {
            if (value == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
            }
            if (value.Length == 0)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("value", SR.GetString("SFxContractDescriptionNameCannotBeEmpty")));
            }
            this.name = new XmlName(value, true);
        }
    }

    public string Namespace
    {
        get
        {
            return this.ns;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                NamingHelper.CheckUriProperty(value, "Namespace");
            }
            this.ns = value;
        }
    }

    public OperationDescriptionCollection Operations
    {
        get
        {
            return this.operations;
        }
    }

    public ProtectionLevel ProtectionLevel
    {
        get
        {
            return this.protectionLevel;
        }
        set
        {
            if (!ProtectionLevelHelper.IsDefined(value))
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("value"));
            }
            this.protectionLevel = value;
            this.hasProtectionLevel = true;
        }
    }

    public SessionMode SessionMode
    {
        get
        {
            return this.sessionMode;
        }
        set
        {
            if (!SessionModeHelper.IsDefined(value))
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("value"));
            }
            this.sessionMode = value;
        }
    }
}
