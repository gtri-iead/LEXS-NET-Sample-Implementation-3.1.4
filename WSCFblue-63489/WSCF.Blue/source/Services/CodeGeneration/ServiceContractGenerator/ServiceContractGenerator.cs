using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Threading;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.IO;
using System.Net.Security;


public class ServiceContractGenerator
{
    // Fields
    private CodeCompileUnit compileUnit;
    private System.Configuration.Configuration configuration;
    private ConfigWriter configWriter;
    private Collection<MetadataConversionError> errors;
    private Dictionary<OperationDescription, OperationContractGenerationContext> generatedOperations;
    private Dictionary<MessageDescription, CodeTypeReference> generatedTypedMessages;
    private Dictionary<ContractDescription, ServiceContractGenerationContext> generatedTypes;
    private NamespaceHelper namespaceManager;
    private OptionsHelper options;
    private Dictionary<ContractDescription, Type> referencedTypes;

    // Methods
    public ServiceContractGenerator() : this(null, null)
    {
    }

    public ServiceContractGenerator(CodeCompileUnit targetCompileUnit) : this(targetCompileUnit, null)
    {
    }

    public ServiceContractGenerator(System.Configuration.Configuration targetConfig) : this(null, targetConfig)
    {
    }

    public ServiceContractGenerator(CodeCompileUnit targetCompileUnit, System.Configuration.Configuration targetConfig)
    {
        this.options = new OptionsHelper(ServiceContractGenerationOptions.ClientClass | ServiceContractGenerationOptions.ChannelInterface);
        this.errors = new Collection<MetadataConversionError>();
        this.compileUnit = targetCompileUnit != null ? targetCompileUnit : new CodeCompileUnit();
        this.namespaceManager = new NamespaceHelper(this.compileUnit.Namespaces);
        this.AddReferencedAssembly(typeof(ServiceContractGenerator).Assembly);
        this.configuration = targetConfig;
        if (targetConfig != null)
        {
            this.configWriter = new ConfigWriter(targetConfig);
        }
        this.generatedTypes = new Dictionary<ContractDescription, ServiceContractGenerationContext>();
        this.generatedOperations = new Dictionary<OperationDescription, OperationContractGenerationContext>();
        this.referencedTypes = new Dictionary<ContractDescription, Type>();
    }

    internal void AddReferencedAssembly(Assembly assembly)
    {
        string fileName = Path.GetFileName(assembly.Location);
        bool flag = false;
        using (StringEnumerator enumerator = this.compileUnit.ReferencedAssemblies.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                if (string.Compare(enumerator.Current, fileName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    flag = true;
                    goto Label_0054;
                }
            }
        }
    Label_0054:
        if (!flag)
        {
            this.compileUnit.ReferencedAssemblies.Add(fileName);
        }
    }

    public void GenerateBinding(Binding binding, out string bindingSectionName, out string configurationName)
    {
        this.configWriter.WriteBinding(binding, out bindingSectionName, out configurationName);
    }

    public CodeTypeReference GenerateServiceContractType(ContractDescription contractDescription)
    {
        CodeTypeReference reference = this.GenerateServiceContractTypeInternal(contractDescription);
        CodeGenerator.ValidateIdentifiers(this.TargetCompileUnit);
        return reference;
    }

    private CodeTypeReference GenerateServiceContractTypeInternal(ContractDescription contractDescription)
    {
        Type type;
        ServiceContractGenerationContext context;
        if (contractDescription == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("contractDescription");
        }
        if (this.referencedTypes.TryGetValue(contractDescription, out type))
        {
            return this.GetCodeTypeReference(type);
        }
        this.NamespaceManager.EnsureNamespace(contractDescription.Namespace);
        if (!this.generatedTypes.TryGetValue(contractDescription, out context))
        {
            context = new ContextInitializer(this, new CodeTypeFactory(this, this.options.IsSet(ServiceContractGenerationOptions.InternalTypes))).CreateContext(contractDescription);
            ExtensionsHelper.CallContractExtensions(this.GetBeforeExtensionsBuiltInContractGenerators(), context);
            ExtensionsHelper.CallOperationExtensions(this.GetBeforeExtensionsBuiltInOperationGenerators(), context);
            ExtensionsHelper.CallBehaviorExtensions(context);
            ExtensionsHelper.CallContractExtensions(this.GetAfterExtensionsBuiltInContractGenerators(), context);
            ExtensionsHelper.CallOperationExtensions(this.GetAfterExtensionsBuiltInOperationGenerators(), context);
            this.generatedTypes.Add(contractDescription, context);
        }
        return context.ContractTypeReference;
    }

    public CodeTypeReference GenerateServiceEndpoint(ServiceEndpoint endpoint, out ChannelEndpointElement channelElement)
    {
        CodeTypeReference codeTypeReference;
        string fullName;
        Type type;
        if (endpoint == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("endpoint");
        }
        if (this.configuration == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new InvalidOperationException(SR.GetString("SFxServiceContractGeneratorConfigRequired")));
        }
        if (this.referencedTypes.TryGetValue(endpoint.Contract, out type))
        {
            codeTypeReference = this.GetCodeTypeReference(type);
            fullName = type.FullName;
        }
        else
        {
            codeTypeReference = this.GenerateServiceContractType(endpoint.Contract);
            fullName = codeTypeReference.BaseType;
        }
        channelElement = this.configWriter.WriteChannelDescription(endpoint, fullName);
        return codeTypeReference;
    }

    private IEnumerable<IServiceContractGenerationExtension> GetAfterExtensionsBuiltInContractGenerators()
    {
        /*<GetAfterExtensionsBuiltInContractGenerators>*/d__3 d__ = new /*<GetAfterExtensionsBuiltInContractGenerators>*/d__3(-2);
        d__./*<>*/_4__this = this;
        return d__;
    }

    private IEnumerable<IOperationContractGenerationExtension> GetAfterExtensionsBuiltInOperationGenerators()
    {
        return EmptyArray<IOperationContractGenerationExtension>.Instance;
    }

    private IEnumerable<IServiceContractGenerationExtension> GetBeforeExtensionsBuiltInContractGenerators()
    {
        return EmptyArray<IServiceContractGenerationExtension>.Instance;
    }

    private IEnumerable<IOperationContractGenerationExtension> GetBeforeExtensionsBuiltInOperationGenerators()
    {
        /*<GetBeforeExtensionsBuiltInOperationGenerators>*/d__0 d__ = new /*<GetBeforeExtensionsBuiltInOperationGenerators>*/d__0(-2);
        d__./*<>*/_4__this = this;
        return d__;
    }

    internal CodeTypeReference GetCodeTypeReference(Type type)
    {
        this.AddReferencedAssembly(type.Assembly);
        return new CodeTypeReference(type);
    }

    internal static CodeExpression GetEnumReference<EnumType>(EnumType value)
    {
        return new CodeFieldReferenceExpression(new CodeTypeReferenceExpression(typeof(EnumType)), Enum.Format(typeof(EnumType), value, "G"));
    }

    // Properties
    public System.Configuration.Configuration Configuration
    {
        get
        {
            return this.configuration;
        }
    }

    public Collection<MetadataConversionError> Errors
    {
        get
        {
            return this.errors;
        }
    }

    internal Dictionary<MessageDescription, CodeTypeReference> GeneratedTypedMessages
    {
        get
        {
            if (this.generatedTypedMessages == null)
            {
                this.generatedTypedMessages = new Dictionary<MessageDescription, CodeTypeReference>(MessageDescriptionComparer.Singleton);
            }
            return this.generatedTypedMessages;
        }
    }

    internal NamespaceHelper NamespaceManager
    {
        get
        {
            return this.namespaceManager;
        }
    }

    public Dictionary<string, string> NamespaceMappings
    {
        get
        {
            return this.NamespaceManager.NamespaceMappings;
        }
    }

    public ServiceContractGenerationOptions Options
    {
        get
        {
            return this.options.Options;
        }
        set
        {
            this.options = new OptionsHelper(value);
        }
    }

    internal OptionsHelper OptionsInternal
    {
        get
        {
            return this.options;
        }
    }

    public Dictionary<ContractDescription, Type> ReferencedTypes
    {
        get
        {
            return this.referencedTypes;
        }
    }

    public CodeCompileUnit TargetCompileUnit
    {
        get
        {
            return this.compileUnit;
        }
    }

    // Nested Types
    //[CompilerGenerated]
    private sealed class /*<GetAfterExtensionsBuiltInContractGenerators>*/d__3 : IEnumerable<IServiceContractGenerationExtension>, 
       IEnumerable, IEnumerator<IServiceContractGenerationExtension>, IEnumerator, IDisposable
    {
        // Fields
        private int /*<>*/_1__state;
        private IServiceContractGenerationExtension /*<>*/_2__current;
        public ServiceContractGenerator /*<>*/_4__this;
        private int /*<>*/_l__initialThreadId;
        public bool /*<generateEventAsyncMethods>*/_5__5;
        public bool /*<tryAddHelperMethod>*/_5__4;

        // Methods
        //[DebuggerHidden]
        public /*<GetAfterExtensionsBuiltInContractGenerators>*/d__3(int /*<>*/_1__state)
        {
            this./*<>*/_1__state = /*<>*/_1__state;
            this./*<>*/_l__initialThreadId = Thread.CurrentThread.ManagedThreadId;
        }

        public bool MoveNext()
        {
            switch (this./*<>*/_1__state)
            {
                case 0:
                    this./*<>*/_1__state = -1;
                    if (!this./*<>*/_4__this.options.IsSet(ServiceContractGenerationOptions.ChannelInterface))
                    {
                        break;
                    }
                    this./*<>*/_2__current = new ServiceContractGenerator.ChannelInterfaceGenerator();
                    this./*<>*/_1__state = 1;
                    return true;

                case 1:
                    this./*<>*/_1__state = -1;
                    break;

                case 2:
                    this./*<>*/_1__state = -1;
                    goto Label_00C0;

                default:
                    goto Label_00C0;
            }
            if (this./*<>*/_4__this.options.IsSet(ServiceContractGenerationOptions.ClientClass))
            {
                this./*<tryAddHelperMethod>*/_5__4 = !this./*<>*/_4__this.options.IsSet(ServiceContractGenerationOptions.TypedMessages);
                this./*<generateEventAsyncMethods>*/_5__5 = this./*<>*/_4__this.options.IsSet(ServiceContractGenerationOptions.EventBasedAsynchronousMethods);
                this./*<>*/_2__current = new ClientClassGenerator(this./*<tryAddHelperMethod>*/_5__4, this./*<generateEventAsyncMethods>*/_5__5);
                this./*<>*/_1__state = 2;
                return true;
            }
        Label_00C0:
            return false;
        }

        //[DebuggerHidden]
        IEnumerator<IServiceContractGenerationExtension> IEnumerable<IServiceContractGenerationExtension>.GetEnumerator()
        {
            if ((Thread.CurrentThread.ManagedThreadId == this./*<>*/_l__initialThreadId) && (this./*<>*/_1__state == -2))
            {
                this./*<>*/_1__state = 0;
                return this;
            }
            ServiceContractGenerator./*<GetAfterExtensionsBuiltInContractGenerators>*/d__3 d__ = new ServiceContractGenerator./*<GetAfterExtensionsBuiltInContractGenerators>*/d__3(0);
            d__./*<>*/_4__this = this./*<>*/_4__this;
            return d__;
        }

        //[DebuggerHidden]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.System.Collections.Generic.IEnumerable<System.ServiceModel.Description.IServiceContractGenerationExtension>.GetEnumerator();
        }

        //[DebuggerHidden]
        void IEnumerator.Reset()
        {
            throw new NotSupportedException();
        }

        void IDisposable.Dispose()
        {
        }

        // Properties
        IServiceContractGenerationExtension IEnumerator<IServiceContractGenerationExtension>.Current
        {
            //[DebuggerHidden]
            get
            {
                return this./*<>*/_2__current;
            }
        }

        object IEnumerator.Current
        {
            //[DebuggerHidden]
            get
            {
                return this./*<>*/_2__current;
            }
        }
    }

    //[CompilerGenerated]
    private sealed class /*<GetBeforeExtensionsBuiltInOperationGenerators>*/d__0 : IEnumerable<IOperationContractGenerationExtension>, 
       IEnumerable, IEnumerator<IOperationContractGenerationExtension>, IEnumerator, IDisposable
    {
        // Fields
        private int /*<>*/_1__state;
        private IOperationContractGenerationExtension/*<>*/_2__current;
        public ServiceContractGenerator /*<>*/_4__this;
        private int /*<>*/_l__initialThreadId;

        // Methods
        //[DebuggerHidden]
        public /*<GetBeforeExtensionsBuiltInOperationGenerators>*/d__0(int /*<>*/_1__state)
        {
            this./*<>*/_1__state = /*<>*/_1__state;
            this./*<>*/_l__initialThreadId = Thread.CurrentThread.ManagedThreadId;
        }

        public bool MoveNext()
        {
            switch (this./*<>*/_1__state)
            {
                case 0:
                    this./*<>*/_1__state = -1;
                    this./*<>*/_2__current = new ServiceContractGenerator.FaultContractAttributeGenerator();
                    this./*<>*/_1__state = 1;
                    return true;

                case 1:
                    this./*<>*/_1__state = -1;
                    this./*<>*/_2__current = new ServiceContractGenerator.TransactionFlowAttributeGenerator();
                    this./*<>*/_1__state = 2;
                    return true;

                case 2:
                    this./*<>*/_1__state = -1;
                    break;
            }
            return false;
        }

        //[DebuggerHidden]
        IEnumerator<IOperationContractGenerationExtension> IEnumerable<IOperationContractGenerationExtension>.GetEnumerator()
        {
            if ((Thread.CurrentThread.ManagedThreadId == this./*<>*/_l__initialThreadId) && (this./*<>*/_1__state == -2))
            {
                this./*<>*/_1__state = 0;
                return this;
            }
            ServiceContractGenerator./*<GetBeforeExtensionsBuiltInOperationGenerators>*/d__0 d__ 
               = new ServiceContractGenerator./*<GetBeforeExtensionsBuiltInOperationGenerators>*/d__0(0);
            d__./*<>*/_4__this = this./*<>*/_4__this;
            return d__;
        }

        //[DebuggerHidden]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.System.Collections.Generic.IEnumerable<System.ServiceModel.Description.IOperationContractGenerationExtension>.GetEnumerator();
        }

        //[DebuggerHidden]
        void IEnumerator.Reset()
        {
            throw new NotSupportedException();
        }

        void IDisposable.Dispose()
        {
        }

        // Properties
        IOperationContractGenerationExtension IEnumerator<IOperationContractGenerationExtension>.Current
        {
            //[DebuggerHidden]
            get
            {
                return this./*<>*/_2__current;
            }
        }

        object IEnumerator.Current
        {
            //[DebuggerHidden]
            get
            {
                return this./*<>*/_2__current;
            }
        }
    }

    private class ChannelInterfaceGenerator : IServiceContractGenerationExtension
    {
        // Methods
        void IServiceContractGenerationExtension.GenerateContract(ServiceContractGenerationContext context)
        {
            CodeTypeDeclaration codeType = context.TypeFactory.CreateInterfaceType();
            codeType.BaseTypes.Add(context.ContractTypeReference);
            codeType.BaseTypes.Add(context.ServiceContractGenerator.GetCodeTypeReference(typeof(IClientChannel)));
            new UniqueCodeNamespaceScope(context.Namespace).AddUnique(codeType, context.ContractType.Name + "Channel", "Channel");
        }
    }

    internal class CodeTypeFactory
    {
        // Fields
        private bool internalTypes;
        private ServiceContractGenerator parent;

        // Methods
        public CodeTypeFactory(ServiceContractGenerator parent, bool internalTypes)
        {
            this.parent = parent;
            this.internalTypes = internalTypes;
        }

        private void AddDebuggerStepThroughAttribute(CodeTypeDeclaration codeType)
        {
            if (codeType.IsClass)
            {
                codeType.CustomAttributes.Add(new CodeAttributeDeclaration(this.parent.GetCodeTypeReference(typeof(DebuggerStepThroughAttribute))));
            }
        }

        private void AddGeneratedCodeAttribute(CodeTypeDeclaration codeType)
        {
            CodeAttributeDeclaration declaration = new CodeAttributeDeclaration(this.parent.GetCodeTypeReference(typeof(GeneratedCodeAttribute)));
            AssemblyName name = Assembly.GetExecutingAssembly().GetName();
            declaration.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(name.Name)));
            declaration.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(name.Version.ToString())));
            codeType.CustomAttributes.Add(declaration);
        }

        private void AddInternal(CodeTypeDeclaration codeType)
        {
            if (this.internalTypes)
            {
                codeType.TypeAttributes &= ~TypeAttributes.Public;
            }
        }

        private void AddPartial(CodeTypeDeclaration codeType)
        {
            if (codeType.IsClass)
            {
                codeType.IsPartial = true;
            }
        }

        public CodeTypeDeclaration CreateClassType()
        {
            return this.CreateCodeType(false);
        }

        private CodeTypeDeclaration CreateCodeType(bool isInterface)
        {
            CodeTypeDeclaration codeType = new CodeTypeDeclaration();
            codeType.IsClass = !isInterface;
            codeType.IsInterface = isInterface;
            this.RunDecorators(codeType);
            return codeType;
        }

        public CodeTypeDeclaration CreateInterfaceType()
        {
            return this.CreateCodeType(true);
        }

        private void RunDecorators(CodeTypeDeclaration codeType)
        {
            this.AddPartial(codeType);
            this.AddInternal(codeType);
            this.AddDebuggerStepThroughAttribute(codeType);
            this.AddGeneratedCodeAttribute(codeType);
        }
    }

    internal class ContextInitializer
    {
        // Fields
        private readonly bool asyncMethods;
        private UniqueCodeIdentifierScope callbackMemberScope;
        private ServiceContractGenerationContext context;
        private UniqueCodeIdentifierScope contractMemberScope;
        private readonly ServiceContractGenerator parent;
        private readonly ServiceContractGenerator.CodeTypeFactory typeFactory;

        // Methods
        internal ContextInitializer(ServiceContractGenerator parent, ServiceContractGenerator.CodeTypeFactory typeFactory)
        {
            this.parent = parent;
            this.typeFactory = typeFactory;
            this.asyncMethods = parent.OptionsInternal.IsSet(ServiceContractGenerationOptions.AsynchronousMethods);
        }

        private void AddOperationContractAttributes(OperationContractGenerationContext context)
        {
            if (context.SyncMethod != null)
            {
                context.SyncMethod.CustomAttributes.Add(this.CreateOperationContractAttributeDeclaration(context.Operation, false));
            }
            if (context.BeginMethod != null)
            {
                context.BeginMethod.CustomAttributes.Add(this.CreateOperationContractAttributeDeclaration(context.Operation, true));
            }
        }

        private void AddServiceContractAttribute(ServiceContractGenerationContext context)
        {
            CodeAttributeDeclaration declaration = new CodeAttributeDeclaration(context.ServiceContractGenerator.GetCodeTypeReference(typeof(ServiceContractAttribute)));
            if (context.ContractType.Name != context.Contract.CodeName)
            {
                string str = (NamingHelper.XmlName(context.Contract.CodeName) == context.Contract.Name) ? context.Contract.CodeName : context.Contract.Name;
                declaration.Arguments.Add(new CodeAttributeArgument("Name", new CodePrimitiveExpression(str)));
            }
            if ("http://tempuri.org/" != context.Contract.Namespace)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(context.Contract.Namespace)));
            }
            declaration.Arguments.Add(new CodeAttributeArgument("ConfigurationName", new CodePrimitiveExpression(ServiceContractGenerator.NamespaceHelper.GetCodeTypeReference(context.Namespace, context.ContractType).BaseType)));
            if (context.Contract.HasProtectionLevel)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("ProtectionLevel", new CodeFieldReferenceExpression(new CodeTypeReferenceExpression(typeof(ProtectionLevel)), context.Contract.ProtectionLevel.ToString())));
            }
            if (context.DuplexCallbackType != null)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("CallbackContract", new CodeTypeOfExpression(context.DuplexCallbackTypeReference)));
            }
            if (context.Contract.SessionMode != SessionMode.Allowed)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("SessionMode", new CodeFieldReferenceExpression(new CodeTypeReferenceExpression(typeof(SessionMode)), context.Contract.SessionMode.ToString())));
            }
            context.ContractType.CustomAttributes.Add(declaration);
        }

        public ServiceContractGenerationContext CreateContext(ContractDescription contractDescription)
        {
            this.VisitContract(contractDescription);
            return this.context;
        }

        private CodeAttributeDeclaration CreateOperationContractAttributeDeclaration(OperationDescription operationDescription, bool asyncPattern)
        {
            CodeAttributeDeclaration declaration = new CodeAttributeDeclaration(this.context.ServiceContractGenerator.GetCodeTypeReference(typeof(OperationContractAttribute)));
            if (operationDescription.IsOneWay)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("IsOneWay", new CodePrimitiveExpression(true)));
            }
            if ((operationDescription.DeclaringContract.SessionMode == SessionMode.Required) && operationDescription.IsTerminating)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("IsTerminating", new CodePrimitiveExpression(true)));
            }
            if ((operationDescription.DeclaringContract.SessionMode == SessionMode.Required) && !operationDescription.IsInitiating)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("IsInitiating", new CodePrimitiveExpression(false)));
            }
            if (asyncPattern)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("AsyncPattern", new CodePrimitiveExpression(true)));
            }
            if (operationDescription.HasProtectionLevel)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("ProtectionLevel", new CodeFieldReferenceExpression(new CodeTypeReferenceExpression(typeof(ProtectionLevel)), operationDescription.ProtectionLevel.ToString())));
            }
            return declaration;
        }

        private static bool IsDuplex(ContractDescription contract)
        {
            foreach (OperationDescription description in contract.Operations)
            {
                if (description.IsServerInitiated())
                {
                    return true;
                }
            }
            return false;
        }

        private void Visit(ContractDescription contractDescription)
        {
            bool flag = IsDuplex(contractDescription);
            this.contractMemberScope = new UniqueCodeIdentifierScope();
            this.callbackMemberScope = flag ? new UniqueCodeIdentifierScope() : null;
            UniqueCodeNamespaceScope scope = new UniqueCodeNamespaceScope(this.parent.NamespaceManager.EnsureNamespace(contractDescription.Namespace));
            CodeTypeDeclaration codeType = this.typeFactory.CreateInterfaceType();
            CodeTypeReference reference = scope.AddUnique(codeType, contractDescription.CodeName, "IContract");
            CodeTypeDeclaration declaration2 = null;
            CodeTypeReference reference2 = null;
            if (flag)
            {
                declaration2 = this.typeFactory.CreateInterfaceType();
                reference2 = scope.AddUnique(declaration2, contractDescription.CodeName + "Callback", "IContract");
            }
            this.context = new ServiceContractGenerationContext(this.parent, contractDescription, codeType, declaration2);
            this.context.Namespace = scope.CodeNamespace;
            this.context.TypeFactory = this.typeFactory;
            this.context.ContractTypeReference = reference;
            this.context.DuplexCallbackTypeReference = reference2;
            this.AddServiceContractAttribute(this.context);
        }

        private void Visit(OperationDescription operationDescription)
        {
            OperationContractGenerationContext context;
            bool flag = operationDescription.IsServerInitiated();
            CodeTypeDeclaration declaringType = flag ? this.context.DuplexCallbackType : this.context.ContractType;
            string str = (flag ? this.callbackMemberScope : this.contractMemberScope).AddUnique(operationDescription.CodeName, "Method");
            CodeMemberMethod method = new CodeMemberMethod();
            method.Name = str;
            declaringType.Members.Add(method);
            if (this.asyncMethods)
            {
                CodeMemberMethod method2 = new CodeMemberMethod();
                method2.Name = "Begin" + str;
                method2.Parameters.Add(new CodeParameterDeclarationExpression(this.context.ServiceContractGenerator.GetCodeTypeReference(typeof(AsyncCallback)), "callback"));
                method2.Parameters.Add(new CodeParameterDeclarationExpression(this.context.ServiceContractGenerator.GetCodeTypeReference(typeof(object)), "asyncState"));
                method2.ReturnType = this.context.ServiceContractGenerator.GetCodeTypeReference(typeof(IAsyncResult));
                declaringType.Members.Add(method2);
                CodeMemberMethod method3 = new CodeMemberMethod();
                method3.Name = "End" + str;
                method3.Parameters.Add(new CodeParameterDeclarationExpression(this.context.ServiceContractGenerator.GetCodeTypeReference(typeof(IAsyncResult)), "result"));
                declaringType.Members.Add(method3);
                context = new OperationContractGenerationContext(this.parent, this.context, operationDescription, declaringType, method, method2, method3);
            }
            else
            {
                context = new OperationContractGenerationContext(this.parent, this.context, operationDescription, declaringType, method);
            }
            context.DeclaringTypeReference = operationDescription.IsServerInitiated() ? this.context.DuplexCallbackTypeReference : this.context.ContractTypeReference;
            this.context.Operations.Add(context);
            this.AddOperationContractAttributes(context);
        }

        private void VisitContract(ContractDescription contract)
        {
            this.Visit(contract);
            foreach (OperationDescription description in contract.Operations)
            {
                this.Visit(description);
            }
        }
    }

    internal static class ExtensionsHelper
    {
        // Methods
        internal static void CallBehaviorExtensions(ServiceContractGenerationContext context)
        {
            CallContractExtensions(EnumerateBehaviorExtensions(context.Contract), context);
            foreach (OperationContractGenerationContext context2 in context.Operations)
            {
                CallOperationExtensions(EnumerateBehaviorExtensions(context2.Operation), context2);
            }
        }

        internal static void CallContractExtensions(IEnumerable<IServiceContractGenerationExtension> extensions, ServiceContractGenerationContext context)
        {
            foreach (IServiceContractGenerationExtension extension in extensions)
            {
                extension.GenerateContract(context);
            }
        }

        private static void CallOperationExtensions(IEnumerable<IOperationContractGenerationExtension> extensions, OperationContractGenerationContext context)
        {
            foreach (IOperationContractGenerationExtension extension in extensions)
            {
                extension.GenerateOperation(context);
            }
        }

        internal static void CallOperationExtensions(IEnumerable<IOperationContractGenerationExtension> extensions, ServiceContractGenerationContext context)
        {
            foreach (OperationContractGenerationContext context2 in context.Operations)
            {
                CallOperationExtensions(extensions, context2);
            }
        }

        private static IEnumerable<IServiceContractGenerationExtension> EnumerateBehaviorExtensions(ContractDescription contract)
        {
            /*<EnumerateBehaviorExtensions>*/d__8 d__ = new /*<EnumerateBehaviorExtensions>*/d__8(-2);
            d__./*<>*/_3__contract = contract;
            return d__;
        }

        private static IEnumerable<IOperationContractGenerationExtension> EnumerateBehaviorExtensions(OperationDescription operation)
        {
            /*<EnumerateBehaviorExtensions>*/d__e _e = new /*<EnumerateBehaviorExtensions>*/d__e(-2);
            _e./*<>*/_3__operation = operation;
            return _e;
        }

        // Nested Types
        //[CompilerGenerated]
        private sealed class /*<EnumerateBehaviorExtensions>*/d__8 : IEnumerable<IServiceContractGenerationExtension>, 
           IEnumerable, IEnumerator<IServiceContractGenerationExtension>, IEnumerator, IDisposable
        {
            // Fields
            private int /*<>*/_1__state;
            private IServiceContractGenerationExtension /*<>*/_2__current;
            public ContractDescription /*<>*/_3__contract;
            public IEnumerator<IContractBehavior> /*<>*/_7__wrapa;
            private int /*<>*/_l__initialThreadId;
            public IContractBehavior /*<behavior>*/_5__9;
            public ContractDescription contract;

            // Methods
            [DebuggerHidden]
            public /*<EnumerateBehaviorExtensions>*/d__8(int /*<>*/_1__state)
            {
                this./*<>*/_1__state = /*<>*/_1__state;
                this./*<>*/_l__initialThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            private void /*<>*/_m__Finallyb()
            {
                this./*<>*/_1__state = -1;
                if (this./*<>*/_7__wrapa != null)
                {
                    this./*<>*/_7__wrapa.Dispose();
                }
            }

            public bool MoveNext()
            {
                bool flag;
                try
                {
                    switch (this./*<>*/_1__state)
                    {
                        case 0:
                            this./*<>*/_1__state = -1;
                            this./*<>*/_7__wrapa = this.contract.Behaviors.GetEnumerator();
                            this./*<>*/_1__state = 1;
                            goto Label_0082;

                        case 2:
                            this./*<>*/_1__state = 1;
                            goto Label_0082;

                        default:
                            goto Label_0095;
                    }
                Label_0041:
                    this./*<behavior>*/_5__9 = this./*<>*/_7__wrapa.Current;
                    if (this./*<behavior>*/_5__9 is IServiceContractGenerationExtension)
                    {
                        this./*<>*/_2__current = (IServiceContractGenerationExtension) this./*<behavior>*/_5__9;
                        this./*<>*/_1__state = 2;
                        return true;
                    }
                Label_0082:
                    if (this./*<>*/_7__wrapa.MoveNext())
                    {
                        goto Label_0041;
                    }
                    this./*<>*/_m__Finallyb();
                Label_0095:
                    flag = false;
                }
                fault
                {
                    this.System.IDisposable.Dispose();
                }
                return flag;
            }

            [DebuggerHidden]
            IEnumerator<IServiceContractGenerationExtension> IEnumerable<IServiceContractGenerationExtension>.GetEnumerator()
            {
                ServiceContractGenerator.ExtensionsHelper./*<EnumerateBehaviorExtensions>*/d__8 d__;
                if ((Thread.CurrentThread.ManagedThreadId == this./*<>*/_l__initialThreadId) && (this./*<>*/_1__state == -2))
                {
                    this./*<>*/_1__state = 0;
                    d__ = this;
                }
                else
                {
                    d__ = new ServiceContractGenerator.ExtensionsHelper./*<EnumerateBehaviorExtensions>*/d__8(0);
                }
                d__.contract = this./*<>*/_3__contract;
                return d__;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return /*this.System.Collections.Generic.IEnumerable<System.ServiceModel.Description.IServiceContractGenerationExtension>.*/GetEnumerator();
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {
                switch (this./*<>*/_1__state)
                {
                    case 1:
                    case 2:
                        try
                        {
                        }
                        finally
                        {
                            this./*<>*/_m__Finallyb();
                        }
                        return;
                }
            }

            // Properties
            IServiceContractGenerationExtension IEnumerator<IServiceContractGenerationExtension>.Current
            {
                [DebuggerHidden]
                get
                {
                    return this./*<>*/_2__current;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return this./*<>*/_2__current;
                }
            }
        }

        //[CompilerGenerated]
        private sealed class /*<EnumerateBehaviorExtensions>*/d__e : IEnumerable<IOperationContractGenerationExtension>, IEnumerable, 
           IEnumerator<IOperationContractGenerationExtension>, IEnumerator, IDisposable
        {
            // Fields
            private int /*<>*/_1__state;
            private IOperationContractGenerationExtension /*<>*/_2__current;
            public OperationDescription /*<>*/_3__operation;
            public IEnumerator<IOperationBehavior> /*<>*/_7__wrap10;
            private int /*<>*/_l__initialThreadId;
            public IOperationBehavior /*<behavior>*/_5__f;
            public OperationDescription operation;

            // Methods
            [DebuggerHidden]
            public /*<EnumerateBehaviorExtensions>*/d__e(int /*<>*/_1__state)
            {
                this./*<>*/_1__state = /*<>*/_1__state;
                this./*<>*/_l__initialThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            private void /*<>*/_m__Finally11()
            {
                this./*<>*/_1__state = -1;
                if (this./*<>*/_7__wrap10 != null)
                {
                   this./*<>*/_7__wrap10.Dispose();
                }
            }

            public bool MoveNext()
            {
                bool flag;
                try
                {
                    switch (this./*<>*/_1__state)
                    {
                        case 0:
                            this./*<>*/_1__state = -1;
                            this./*<>*/_7__wrap10 = this.operation.Behaviors.GetEnumerator();
                            this./*<>*/_1__state = 1;
                            goto Label_0082;

                        case 2:
                            this./*<>*/_1__state = 1;
                            goto Label_0082;

                        default:
                            goto Label_0095;
                    }
                Label_0041:
                    this./*<behavior>*/_5__f = this./*<>*/_7__wrap10.Current;
                    if (this./*<behavior>*/_5__f is IOperationContractGenerationExtension)
                    {
                        this./*<>*/_2__current = (IOperationContractGenerationExtension) this./*<behavior>*/5__f;
                        this./*<>*/_1__state = 2;
                        return true;
                    }
                Label_0082:
                    if (this./*<>*/_7__wrap10.MoveNext())
                    {
                        goto Label_0041;
                    }
                    this./*<>*/_m__Finally11();
                Label_0095:
                    flag = false;
                }
                fault
                {
                    this.System.IDisposable.Dispose();
                }
                return flag;
            }

            //[DebuggerHidden]
            IEnumerator<IOperationContractGenerationExtension> IEnumerable<IOperationContractGenerationExtension>.GetEnumerator()
            {
                ServiceContractGenerator.ExtensionsHelper./*<EnumerateBehaviorExtensions>*/d__e _e;
                if ((Thread.CurrentThread.ManagedThreadId == this./*<>*/_>l__initialThreadId) && (this./*<>*/_1__state == -2))
                {
                    this./*<>*/_1__state = 0;
                    _e = this;
                }
                else
                {
                    _e = new ServiceContractGenerator.ExtensionsHelper.<EnumerateBehaviorExtensions>d__e(0);
                }
                _e.operation = this./*<>*/_3__operation;
                return _e;
            }

            //[DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.System.Collections.Generic.IEnumerable<System.ServiceModel.Description.IOperationContractGenerationExtension>.GetEnumerator();
            }

            //[DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {
                switch (this./*<>*/_1__state)
                {
                    case 1:
                    case 2:
                        try
                        {
                        }
                        finally
                        {
                           this./*<>*/_m__Finally11();
                        }
                        return;
                }
            }

            // Properties
            IOperationContractGenerationExtension IEnumerator<IOperationContractGenerationExtension>.Current
            {
                [DebuggerHidden]
                get
                {
                   return this./*<>*/_2__current;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                   return this./*<>*/_2__current;
                }
            }
        }
    }

    private class FaultContractAttributeGenerator : IOperationContractGenerationExtension
    {
        // Fields
        private static CodeTypeReference voidTypeReference = new CodeTypeReference(typeof(void));

        // Methods
        private static CodeAttributeDeclaration CreateAttrDecl(OperationContractGenerationContext context, FaultDescription fault)
        {
            CodeTypeReference type = (fault.DetailType != null) ? context.Contract.ServiceContractGenerator.GetCodeTypeReference(fault.DetailType) : fault.DetailTypeReference;
            if ((type == null) || (type == voidTypeReference))
            {
                return null;
            }
            CodeAttributeDeclaration declaration = new CodeAttributeDeclaration(context.ServiceContractGenerator.GetCodeTypeReference(typeof(FaultContractAttribute)));
            declaration.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(type)));
            if (fault.Action != null)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("Action", new CodePrimitiveExpression(fault.Action)));
            }
            if (fault.HasProtectionLevel)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("ProtectionLevel", new CodeFieldReferenceExpression(new CodeTypeReferenceExpression(typeof(ProtectionLevel)), fault.ProtectionLevel.ToString())));
            }
            if (!XmlName.IsNullOrEmpty(fault.ElementName))
            {
                declaration.Arguments.Add(new CodeAttributeArgument("Name", new CodePrimitiveExpression(fault.ElementName.EncodedName)));
            }
            if (fault.Namespace != context.Contract.Contract.Namespace)
            {
                declaration.Arguments.Add(new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(fault.Namespace)));
            }
            return declaration;
        }

        void IOperationContractGenerationExtension.GenerateOperation(OperationContractGenerationContext context)
        {
            CodeMemberMethod method = context.SyncMethod ?? context.BeginMethod;
            foreach (FaultDescription description in context.Operation.Faults)
            {
                CodeAttributeDeclaration declaration = CreateAttrDecl(context, description);
                if (declaration != null)
                {
                    method.CustomAttributes.Add(declaration);
                }
            }
        }
    }

    private class MessageDescriptionComparer : IEqualityComparer<MessageDescription>
    {
        // Fields
        internal static ServiceContractGenerator.MessageDescriptionComparer Singleton = new ServiceContractGenerator.MessageDescriptionComparer();

        // Methods
        private MessageDescriptionComparer()
        {
        }

        bool IEqualityComparer<MessageDescription>.Equals(MessageDescription x, MessageDescription y)
        {
            if (x.XsdTypeName != y.XsdTypeName)
            {
                return false;
            }
            if (x.Headers.Count != y.Headers.Count)
            {
                return false;
            }
            MessageHeaderDescription[] array = new MessageHeaderDescription[x.Headers.Count];
            x.Headers.CopyTo(array, 0);
            MessageHeaderDescription[] descriptionArray2 = new MessageHeaderDescription[y.Headers.Count];
            y.Headers.CopyTo(descriptionArray2, 0);
            if (x.Headers.Count > 1)
            {
                Array.Sort<MessagePartDescription>((MessagePartDescription[]) array, MessagePartDescriptionComparer.Singleton);
                Array.Sort<MessagePartDescription>((MessagePartDescription[]) descriptionArray2, MessagePartDescriptionComparer.Singleton);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (MessagePartDescriptionComparer.Singleton.Compare(array[i], descriptionArray2[i]) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        int IEqualityComparer<MessageDescription>.GetHashCode(MessageDescription obj)
        {
            return obj.XsdTypeName.GetHashCode();
        }

        // Nested Types
        private class MessagePartDescriptionComparer : IComparer<MessagePartDescription>
        {
            // Fields
            internal static ServiceContractGenerator.MessageDescriptionComparer.MessagePartDescriptionComparer Singleton = new ServiceContractGenerator.MessageDescriptionComparer.MessagePartDescriptionComparer();

            // Methods
            private MessagePartDescriptionComparer()
            {
            }

            public int Compare(MessagePartDescription p1, MessagePartDescription p2)
            {
                if (p1 == null)
                {
                    if (p2 != null)
                    {
                        return -1;
                    }
                    return 0;
                }
                if (p2 == null)
                {
                    return 1;
                }
                int num = string.CompareOrdinal(p1.Namespace, p2.Namespace);
                if (num == 0)
                {
                    num = string.CompareOrdinal(p1.Name, p2.Name);
                }
                return num;
            }
        }
    }

    internal class NamespaceHelper
    {
        // Fields
        private readonly CodeNamespaceCollection codeNamespaces;
        private Dictionary<string, string> namespaceMappings;
        private static readonly object referenceKey = new object();
        private const string WildcardNamespaceMapping = "*";

        // Methods
        public NamespaceHelper(CodeNamespaceCollection namespaces)
        {
            this.codeNamespaces = namespaces;
        }

        private string DescriptionToCode(string descriptionNamespace)
        {
            string str = string.Empty;
            if ((this.namespaceMappings != null) && !this.namespaceMappings.TryGetValue(descriptionNamespace, out str))
            {
                this.namespaceMappings.TryGetValue("*", out str);
            }
            return str;
        }

        public CodeNamespace EnsureNamespace(string descriptionNamespace)
        {
            string ns = this.DescriptionToCode(descriptionNamespace);
            CodeNamespace namespace2 = this.FindNamespace(ns);
            if (namespace2 == null)
            {
                namespace2 = new CodeNamespace(ns);
                this.codeNamespaces.Add(namespace2);
            }
            return namespace2;
        }

        private CodeNamespace FindNamespace(string ns)
        {
            foreach (CodeNamespace namespace2 in this.codeNamespaces)
            {
                if (namespace2.Name == ns)
                {
                    return namespace2;
                }
            }
            return null;
        }

        public static CodeTypeDeclaration GetCodeType(CodeTypeReference codeTypeReference)
        {
            return (codeTypeReference.UserData[referenceKey] as CodeTypeDeclaration);
        }

        internal static CodeTypeReference GetCodeTypeReference(CodeNamespace codeNamespace, CodeTypeDeclaration codeType)
        {
            CodeTypeReference reference = new CodeTypeReference(string.IsNullOrEmpty(codeNamespace.Name) ? codeType.Name : (codeNamespace.Name + '.' + codeType.Name));
            reference.UserData[referenceKey] = codeType;
            return reference;
        }

        // Properties
        public Dictionary<string, string> NamespaceMappings
        {
            get
            {
                if (this.namespaceMappings == null)
                {
                    this.namespaceMappings = new Dictionary<string, string>();
                }
                return this.namespaceMappings;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct OptionsHelper
    {
        public readonly ServiceContractGenerationOptions Options;
        public OptionsHelper(ServiceContractGenerationOptions options)
        {
            this.Options = options;
        }

        public bool IsSet(ServiceContractGenerationOptions option)
        {
            return ((this.Options & option) != ServiceContractGenerationOptions.None);
        }

        private static bool IsSingleBit(int x)
        {
            return ((x != 0) && ((x & (x + -1)) == 0));
        }
    }

    private static class Strings
    {
        // Fields
        public const string AsyncCallbackArgName = "callback";
        public const string AsyncResultArgName = "result";
        public const string AsyncStateArgName = "asyncState";
        public const string CallbackTypeSuffix = "Callback";
        public const string ChannelTypeSuffix = "Channel";
        public const string DefaultContractName = "IContract";
        public const string DefaultOperationName = "Method";
        public const string InterfaceTypePrefix = "I";
    }

    private class TransactionFlowAttributeGenerator : IOperationContractGenerationExtension
    {
        // Methods
        private static CodeAttributeDeclaration CreateAttrDecl(OperationContractGenerationContext context, TransactionFlowAttribute attr)
        {
            CodeAttributeDeclaration declaration = new CodeAttributeDeclaration(context.Contract.ServiceContractGenerator.GetCodeTypeReference(typeof(TransactionFlowAttribute)));
            declaration.Arguments.Add(new CodeAttributeArgument(ServiceContractGenerator.GetEnumReference<TransactionFlowOption>(attr.Transactions)));
            return declaration;
        }

        void IOperationContractGenerationExtension.GenerateOperation(OperationContractGenerationContext context)
        {
            TransactionFlowAttribute attr = context.Operation.Behaviors.Find<TransactionFlowAttribute>();
            if ((attr != null) && (attr.Transactions != TransactionFlowOption.NotAllowed))
            {
                CodeMemberMethod method = context.SyncMethod ?? context.BeginMethod;
                method.CustomAttributes.Add(CreateAttrDecl(context, attr));
            }
        }
    }
}
 
