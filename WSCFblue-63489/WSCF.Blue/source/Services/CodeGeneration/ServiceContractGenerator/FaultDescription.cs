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


[DebuggerDisplay("Name={name}, Action={action}, DetailType={detailType}")]
public class FaultDescription
{
    // Fields
    private string action;
    private Type detailType;
    private CodeTypeReference detailTypeReference;
    private XmlName elementName;
    private bool hasProtectionLevel;
    private XmlName name;
    private string ns;
    private ProtectionLevel protectionLevel;

    // Methods
    public FaultDescription(string action)
    {
        if (action == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentNullException("action"));
        }
        this.action = action;
    }

    internal void ResetProtectionLevel()
    {
        this.protectionLevel = ProtectionLevel.None;
        this.hasProtectionLevel = false;
    }

    internal void SetNameAndElement(XmlName name)
    {
        this.elementName = this.name = name;
    }

    internal void SetNameOnly(XmlName name)
    {
        this.name = name;
    }

    // Properties
    public string Action
    {
        get
        {
            return this.action;
        }
        internal set
        {
            this.action = value;
        }
    }

    public Type DetailType
    {
        get
        {
            return this.detailType;
        }
        set
        {
            this.detailType = value;
        }
    }

    internal CodeTypeReference DetailTypeReference
    {
        get
        {
            return this.detailTypeReference;
        }
        set
        {
            this.detailTypeReference = value;
        }
    }

    internal XmlName ElementName
    {
        get
        {
            return this.elementName;
        }
        set
        {
            this.elementName = value;
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
            this.SetNameAndElement(new XmlName(value, true));
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
            this.ns = value;
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
}

