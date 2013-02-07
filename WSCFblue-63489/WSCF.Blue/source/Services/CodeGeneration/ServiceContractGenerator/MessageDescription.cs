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


[DebuggerDisplay("Action={action}, Direction={direction}, MessageType={messageType}")]
public class MessageDescription
{
    // Fields
    private string action;
    private MessageDirection direction;
    private bool hasProtectionLevel;
    private MessageDescriptionItems items;
    private XmlName messageName;
    private Type messageType;
    private ProtectionLevel protectionLevel;
    private XmlQualifiedName xsdType;

    // Methods
    internal MessageDescription(MessageDescription other)
    {
        this.action = other.action;
        this.direction = other.direction;
        this.Items.Body = other.Items.Body.Clone();
        foreach (MessageHeaderDescription description in other.Items.Headers)
        {
            this.Items.Headers.Add(description.Clone() as MessageHeaderDescription);
        }
        foreach (MessagePropertyDescription description2 in other.Items.Properties)
        {
            this.Items.Properties.Add(description2.Clone() as MessagePropertyDescription);
        }
        this.MessageName = other.MessageName;
        this.MessageType = other.MessageType;
        this.XsdTypeName = other.XsdTypeName;
        this.hasProtectionLevel = other.hasProtectionLevel;
        this.ProtectionLevel = other.ProtectionLevel;
    }

    public MessageDescription(string action, MessageDirection direction) : this(action, direction, null)
    {
    }

    internal MessageDescription(string action, MessageDirection direction, MessageDescriptionItems items)
    {
        if (!MessageDirectionHelper.IsDefined(direction))
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentOutOfRangeException("direction"));
        }
        this.action = action;
        this.direction = direction;
        this.items = items;
    }

    internal MessageDescription Clone()
    {
        return new MessageDescription(this);
    }

    internal void ResetProtectionLevel()
    {
        this.protectionLevel = ProtectionLevel.None;
        this.hasProtectionLevel = false;
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

    public MessageBodyDescription Body
    {
        get
        {
            return this.Items.Body;
        }
    }

    public MessageDirection Direction
    {
        get
        {
            return this.direction;
        }
    }

    public bool HasProtectionLevel
    {
        get
        {
            return this.hasProtectionLevel;
        }
    }

    public MessageHeaderDescriptionCollection Headers
    {
        get
        {
            return this.Items.Headers;
        }
    }

    internal bool IsTypedMessage
    {
        get
        {
            return (this.messageType != null);
        }
    }

    internal bool IsUntypedMessage
    {
        get
        {
            return ((((this.Body.ReturnValue != null) && (this.Body.Parts.Count == 0)) && (this.Body.ReturnValue.Type == typeof(Message))) || (((this.Body.ReturnValue == null) && (this.Body.Parts.Count == 1)) && (this.Body.Parts[0].Type == typeof(Message))));
        }
    }

    internal bool IsVoid
    {
        get
        {
            if (this.IsTypedMessage || (this.Body.Parts.Count != 0))
            {
                return false;
            }
            if (this.Body.ReturnValue != null)
            {
                return (this.Body.ReturnValue.Type == typeof(void));
            }
            return true;
        }
    }

    internal MessageDescriptionItems Items
    {
        get
        {
            if (this.items == null)
            {
                this.items = new MessageDescriptionItems();
            }
            return this.items;
        }
    }

    internal XmlName MessageName
    {
        get
        {
            return this.messageName;
        }
        set
        {
            this.messageName = value;
        }
    }

    public Type MessageType
    {
        get
        {
            return this.messageType;
        }
        set
        {
            this.messageType = value;
        }
    }

    public MessagePropertyDescriptionCollection Properties
    {
        get
        {
            return this.Items.Properties;
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

    internal XmlQualifiedName XsdTypeName
    {
        get
        {
            return this.xsdType;
        }
        set
        {
            this.xsdType = value;
        }
    }
}
