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


[DebuggerDisplay("Name={name}, Namespace={ns}, Type={Type}, Index={index}}")]
public class MessagePartDescription
{
    // Fields
    private ICustomAttributeProvider additionalAttributesProvider;
    private string baseType;
    private bool hasProtectionLevel;
    private int index;
    private MemberInfo memberInfo;
    private bool multiple;
    private XmlName name;
    private string ns;
    private ProtectionLevel protectionLevel;
    private int serializationPosition;
    private Type type;
    private string uniquePartName;

    // Methods
    internal MessagePartDescription(MessagePartDescription other)
    {
        this.name = other.name;
        this.ns = other.ns;
        this.index = other.index;
        this.type = other.type;
        this.serializationPosition = other.serializationPosition;
        this.hasProtectionLevel = other.hasProtectionLevel;
        this.protectionLevel = other.protectionLevel;
        this.memberInfo = other.memberInfo;
        this.multiple = other.multiple;
        this.additionalAttributesProvider = other.additionalAttributesProvider;
        this.baseType = other.baseType;
        this.uniquePartName = other.uniquePartName;
    }

    public MessagePartDescription(string name, string ns)
    {
        if (name == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("name");
        }
        this.name = new XmlName(name, true);
        if (!string.IsNullOrEmpty(ns))
        {
            NamingHelper.CheckUriParameter(ns, "ns");
        }
        this.ns = ns;
    }

    internal virtual MessagePartDescription Clone()
    {
        return new MessagePartDescription(this);
    }

    internal void ResetProtectionLevel()
    {
        this.protectionLevel = ProtectionLevel.None;
        this.hasProtectionLevel = false;
    }

    // Properties
    internal ICustomAttributeProvider AdditionalAttributesProvider
    {
        get
        {
            return (this.additionalAttributesProvider ?? this.memberInfo);
        }
        set
        {
            this.additionalAttributesProvider = value;
        }
    }

    internal string BaseType
    {
        get
        {
            return this.baseType;
        }
        set
        {
            this.baseType = value;
        }
    }

    internal string CodeName
    {
        get
        {
            return this.name.DecodedName;
        }
    }

    public bool HasProtectionLevel
    {
        get
        {
            return this.hasProtectionLevel;
        }
    }

    public int Index
    {
        get
        {
            return this.index;
        }
        set
        {
            this.index = value;
        }
    }

    public MemberInfo MemberInfo
    {
        get
        {
            return this.memberInfo;
        }
        set
        {
            this.memberInfo = value;
        }
    }

    public bool Multiple
    {
        get
        {
            return this.multiple;
        }
        set
        {
            this.multiple = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name.EncodedName;
        }
    }

    public string Namespace
    {
        get
        {
            return this.ns;
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

    internal int SerializationPosition
    {
        get
        {
            return this.serializationPosition;
        }
        set
        {
            this.serializationPosition = value;
        }
    }

    public Type Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }

    internal string UniquePartName
    {
        get
        {
            return this.uniquePartName;
        }
        set
        {
            this.uniquePartName = value;
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
