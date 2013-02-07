using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;


public class MessageHeaderDescription : MessagePartDescription
{
    // Fields
    private string actor;
    private bool isUnknownHeader;
    private bool mustUnderstand;
    private bool relay;
    private bool typedHeader;

    // Methods
    internal MessageHeaderDescription(MessageHeaderDescription other) : base(other)
    {
        this.MustUnderstand = other.MustUnderstand;
        this.Relay = other.Relay;
        this.Actor = other.Actor;
        this.TypedHeader = other.TypedHeader;
        this.IsUnknownHeaderCollection = other.IsUnknownHeaderCollection;
    }

    public MessageHeaderDescription(string name, string ns) : base(name, ns)
    {
    }

    internal override MessagePartDescription Clone()
    {
        return new MessageHeaderDescription(this);
    }

    // Properties
    public string Actor
    {
        get
        {
            return this.actor;
        }
        set
        {
            this.actor = value;
        }
    }

    internal bool IsUnknownHeaderCollection
    {
        get
        {
            return (this.isUnknownHeader || (base.Multiple && (base.Type == typeof(XmlElement))));
        }
        set
        {
            this.isUnknownHeader = value;
        }
    }

    public bool MustUnderstand
    {
        get
        {
            return this.mustUnderstand;
        }
        set
        {
            this.mustUnderstand = value;
        }
    }

    public bool Relay
    {
        get
        {
            return this.relay;
        }
        set
        {
            this.relay = value;
        }
    }

    public bool TypedHeader
    {
        get
        {
            return this.typedHeader;
        }
        set
        {
            this.typedHeader = value;
        }
    }
}
