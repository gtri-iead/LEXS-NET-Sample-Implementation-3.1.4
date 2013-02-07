using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;


public class MessageBodyDescription
{
    // Fields
    private MessagePartDescriptionCollection parts;
    private MessagePartDescription returnValue;
    private XmlName wrapperName;
    private string wrapperNs;

    // Methods
    public MessageBodyDescription()
    {
        this.parts = new MessagePartDescriptionCollection();
    }

    internal MessageBodyDescription(MessageBodyDescription other)
    {
        this.WrapperName = other.WrapperName;
        this.WrapperNamespace = other.WrapperNamespace;
        this.parts = new MessagePartDescriptionCollection();
        foreach (MessagePartDescription description in other.Parts)
        {
            this.Parts.Add(description.Clone());
        }
        if (other.ReturnValue != null)
        {
            this.ReturnValue = other.ReturnValue.Clone();
        }
    }

    internal MessageBodyDescription Clone()
    {
        return new MessageBodyDescription(this);
    }

    // Properties
    public MessagePartDescriptionCollection Parts
    {
        get
        {
            return this.parts;
        }
    }

    public MessagePartDescription ReturnValue
    {
        get
        {
            return this.returnValue;
        }
        set
        {
            this.returnValue = value;
        }
    }

    public string WrapperName
    {
        get
        {
            if (this.wrapperName != null)
            {
                return this.wrapperName.EncodedName;
            }
            return null;
        }
        set
        {
            this.wrapperName = new XmlName(value, true);
        }
    }

    public string WrapperNamespace
    {
        get
        {
            return this.wrapperNs;
        }
        set
        {
            this.wrapperNs = value;
        }
    }
}
