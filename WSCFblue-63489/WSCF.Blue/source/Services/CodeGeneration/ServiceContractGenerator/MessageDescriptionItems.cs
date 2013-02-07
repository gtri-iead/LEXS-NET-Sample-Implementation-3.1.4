using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;



internal class MessageDescriptionItems
{
    // Fields
    private MessageBodyDescription body;
    private MessageHeaderDescriptionCollection headers;
    private MessagePropertyDescriptionCollection properties;

    // Properties
    internal MessageBodyDescription Body
    {
        get
        {
            if (this.body == null)
            {
                this.body = new MessageBodyDescription();
            }
            return this.body;
        }
        set
        {
            this.body = value;
        }
    }

    internal MessageHeaderDescriptionCollection Headers
    {
        get
        {
            if (this.headers == null)
            {
                this.headers = new MessageHeaderDescriptionCollection();
            }
            return this.headers;
        }
    }

    internal MessagePropertyDescriptionCollection Properties
    {
        get
        {
            if (this.properties == null)
            {
                this.properties = new MessagePropertyDescriptionCollection();
            }
            return this.properties;
        }
    }
}

