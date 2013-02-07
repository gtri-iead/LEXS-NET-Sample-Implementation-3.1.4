
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;

public class OperationContractGenerationContext
{
    // Fields
    private readonly CodeMemberMethod beginMethod;
    private readonly ServiceContractGenerationContext contract;
    private readonly CodeTypeDeclaration declaringType;
    private CodeTypeReference declaringTypeReference;
    private readonly CodeMemberMethod endMethod;
    private readonly OperationDescription operation;
    private readonly ServiceContractGenerator serviceContractGenerator;
    private readonly CodeMemberMethod syncMethod;

    // Methods
    private OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, 
       ServiceContractGenerationContext contract, OperationDescription operation, CodeTypeDeclaration declaringType)
    {
        if (serviceContractGenerator == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("serviceContractGenerator"));
        }
        if (contract == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("contract"));
        }
        if (declaringType == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("declaringType"));
        }
        this.serviceContractGenerator = serviceContractGenerator;
        this.contract = contract;
        this.operation = operation;
        this.declaringType = declaringType;
    }

    public OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ServiceContractGenerationContext contract, 
       OperationDescription operation, CodeTypeDeclaration declaringType, CodeMemberMethod method) : this(serviceContractGenerator, contract, operation, declaringType)
    {
        if (method == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("method"));
        }
        this.syncMethod = method;
        this.beginMethod = null;
        this.endMethod = null;
    }

    public OperationContractGenerationContext(ServiceContractGenerator serviceContractGenerator, ServiceContractGenerationContext contract, 
       OperationDescription operation, CodeTypeDeclaration declaringType, CodeMemberMethod syncMethod, CodeMemberMethod beginMethod, 
       CodeMemberMethod endMethod) : this(serviceContractGenerator, contract, operation, declaringType)
    {
        if (syncMethod == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("syncMethod"));
        }
        if (beginMethod == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("beginMethod"));
        }
        if (endMethod == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("endMethod"));
        }
        this.syncMethod = syncMethod;
        this.beginMethod = beginMethod;
        this.endMethod = endMethod;
    }

    // Properties
    public CodeMemberMethod BeginMethod
    {
        get
        {
            return this.beginMethod;
        }
    }

    public ServiceContractGenerationContext Contract
    {
        get
        {
            return this.contract;
        }
    }

    public CodeTypeDeclaration DeclaringType
    {
        get
        {
            return this.declaringType;
        }
    }

    internal CodeTypeReference DeclaringTypeReference
    {
        get
        {
            return this.declaringTypeReference;
        }
        set
        {
            this.declaringTypeReference = value;
        }
    }

    public CodeMemberMethod EndMethod
    {
        get
        {
            return this.endMethod;
        }
    }

    public bool IsAsync
    {
        get
        {
            return (this.beginMethod != null);
        }
    }

    internal bool IsInherited
    {
        get
        {
            return ((this.declaringType != this.contract.ContractType) && (this.declaringType != this.contract.DuplexCallbackType));
        }
    }

    public OperationDescription Operation
    {
        get
        {
            return this.operation;
        }
    }

    public ServiceContractGenerator ServiceContractGenerator
    {
        get
        {
            return this.serviceContractGenerator;
        }
    }

    public CodeMemberMethod SyncMethod
    {
        get
        {
            return this.syncMethod;
        }
    }
}

