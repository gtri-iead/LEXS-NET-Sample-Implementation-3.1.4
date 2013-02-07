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
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.IO;



internal class UniqueCodeNamespaceScope : UniqueCodeIdentifierScope
{
    // Fields
    private CodeNamespace codeNamespace;

    // Methods
    public UniqueCodeNamespaceScope(CodeNamespace codeNamespace)
    {
        this.codeNamespace = codeNamespace;
    }

    protected override void AddIdentifier(string identifier)
    {
    }

    public CodeTypeReference AddUnique(CodeTypeDeclaration codeType, string name, string defaultName)
    {
        codeType.Name = base.AddUnique(name, defaultName);
        this.codeNamespace.Types.Add(codeType);
        return ServiceContractGenerator.NamespaceHelper.GetCodeTypeReference(this.codeNamespace, codeType);
    }

    public override bool IsUnique(string identifier)
    {
        return !this.NamespaceContainsType(identifier);
    }

    private bool NamespaceContainsType(string typeName)
    {
        foreach (CodeTypeDeclaration declaration in this.codeNamespace.Types)
        {
            if (string.Compare(declaration.Name, typeName, StringComparison.OrdinalIgnoreCase) == 0)
            {
                return true;
            }
        }
        return false;
    }

    // Properties
    public CodeNamespace CodeNamespace
    {
        get
        {
            return this.codeNamespace;
        }
    }
}
