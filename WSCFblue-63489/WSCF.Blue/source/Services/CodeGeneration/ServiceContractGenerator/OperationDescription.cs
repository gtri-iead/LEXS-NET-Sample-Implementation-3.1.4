using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;
using System.Net.Security;
using System.Collections.ObjectModel;

[DebuggerDisplay("Name={name}, IsInitiating={isInitiating}, IsTerminating={isTerminating}")]
public class OperationDescription
{
    // Fields
    private MethodInfo beginMethod;
    private KeyedByTypeCollection<IOperationBehavior> behaviors;
    private ContractDescription declaringContract;
    private MethodInfo endMethod;
    private FaultDescriptionCollection faults;
    private bool hasNoDisposableParameters;
    private bool hasProtectionLevel;
    private bool isInitiating;
    private bool isTerminating;
    private Collection<Type> knownTypes;
    private MessageDescriptionCollection messages;
    private XmlName name;
    private ProtectionLevel protectionLevel;
    private MethodInfo syncMethod;
    private bool validateRpcWrapperName;

    // Methods
    public OperationDescription(string name, ContractDescription declaringContract)
    {
        this.validateRpcWrapperName = true;
        if (name == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("name");
        }
        if (name.Length == 0)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("name", SR.GetString("SFxOperationDescriptionNameCannotBeEmpty")));
        }
        this.name = new XmlName(name, true);
        if (declaringContract == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("declaringContract");
        }
        this.declaringContract = declaringContract;
        this.isInitiating = true;
        this.isTerminating = false;
        this.faults = new FaultDescriptionCollection();
        this.messages = new MessageDescriptionCollection();
        this.behaviors = new KeyedByTypeCollection<IOperationBehavior>();
        this.knownTypes = new Collection<Type>();
    }

    internal OperationDescription(string name, ContractDescription declaringContract, bool validateRpcWrapperName) : this(name, declaringContract)
    {
        this.validateRpcWrapperName = validateRpcWrapperName;
    }

    internal void EnsureInvariants()
    {
        if ((this.Messages.Count != 1) && (this.Messages.Count != 2))
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("SFxOperationMustHaveOneOrTwoMessages", new object[] { this.Name })));
        }
    }

    internal bool IsServerInitiated()
    {
        this.EnsureInvariants();
        return (this.Messages[0].Direction == MessageDirection.Output);
    }

    internal void ResetProtectionLevel()
    {
        this.protectionLevel = ProtectionLevel.None;
        this.hasProtectionLevel = false;
    }

    // Properties
    public MethodInfo BeginMethod
    {
        get
        {
            return this.beginMethod;
        }
        set
        {
            this.beginMethod = value;
        }
    }

    public KeyedByTypeCollection<IOperationBehavior> Behaviors
    {
        get
        {
            return this.behaviors;
        }
    }

    internal string CodeName
    {
        get
        {
            return this.name.DecodedName;
        }
    }

    public ContractDescription DeclaringContract
    {
        get
        {
            return this.declaringContract;
        }
        set
        {
            if (value == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("DeclaringContract");
            }
            this.declaringContract = value;
        }
    }

    public MethodInfo EndMethod
    {
        get
        {
            return this.endMethod;
        }
        set
        {
            this.endMethod = value;
        }
    }

    public FaultDescriptionCollection Faults
    {
        get
        {
            return this.faults;
        }
    }

    internal bool HasNoDisposableParameters
    {
        get
        {
            return this.hasNoDisposableParameters;
        }
        set
        {
            this.hasNoDisposableParameters = value;
        }
    }

    public bool HasProtectionLevel
    {
        get
        {
            return this.hasProtectionLevel;
        }
    }

    public bool IsInitiating
    {
        get
        {
            return this.isInitiating;
        }
        set
        {
            this.isInitiating = value;
        }
    }

    public bool IsOneWay
    {
        get
        {
            return (this.Messages.Count == 1);
        }
    }

    public bool IsTerminating
    {
        get
        {
            return this.isTerminating;
        }
        set
        {
            this.isTerminating = value;
        }
    }

    internal bool IsValidateRpcWrapperName
    {
        get
        {
            return this.validateRpcWrapperName;
        }
    }

    public Collection<Type> KnownTypes
    {
        get
        {
            return this.knownTypes;
        }
    }

    public MessageDescriptionCollection Messages
    {
        get
        {
            return this.messages;
        }
    }

    public string Name
    {
        get
        {
            return this.name.EncodedName;
        }
    }

    internal MethodInfo OperationMethod
    {
        get
        {
            return (this.SyncMethod ?? this.BeginMethod);
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

    public MethodInfo SyncMethod
    {
        get
        {
            return this.syncMethod;
        }
        set
        {
            this.syncMethod = value;
        }
    }

    internal XmlName XmlName
    {
        get
        {
            return this.name;
        }
    }
}
