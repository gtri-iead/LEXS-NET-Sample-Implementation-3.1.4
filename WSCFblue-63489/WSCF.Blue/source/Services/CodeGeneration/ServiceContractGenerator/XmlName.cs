﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.ServiceModel;
using System.Reflection;
using System.ServiceModel.Channels;


internal class XmlName
{
    // Fields
    private string decoded;
    private string encoded;

    // Methods
    internal XmlName(string name) : this(name, false)
    {
    }

    internal XmlName(string name, bool isEncoded)
    {
        if (isEncoded)
        {
            ValidateEncodedName(name, true);
            this.encoded = name;
        }
        else
        {
            this.decoded = name;
        }
    }

    public override bool Equals(object obj)
    {
        if (object.ReferenceEquals(obj, this))
        {
            return true;
        }
        if (object.ReferenceEquals(obj, null))
        {
            return false;
        }
        XmlName xmlName = obj as XmlName;
        if (xmlName == null)
        {
            return false;
        }
        return this.Matches(xmlName);
    }

    public override int GetHashCode()
    {
        if (string.IsNullOrEmpty(this.EncodedName))
        {
            return 0;
        }
        return this.EncodedName.GetHashCode();
    }

    internal static bool IsNullOrEmpty(XmlName xmlName)
    {
        if (xmlName != null)
        {
            return xmlName.IsEmpty;
        }
        return true;
    }

    private bool Matches(XmlName xmlName)
    {
        return string.Equals(this.EncodedName, xmlName.EncodedName, StringComparison.Ordinal);
    }

    public static bool operator ==(XmlName a, XmlName b)
    {
        if (object.ReferenceEquals(a, null))
        {
            return object.ReferenceEquals(b, null);
        }
        return a.Equals(b);
    }

    public static bool operator !=(XmlName a, XmlName b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        if ((this.encoded == null) && (this.decoded == null))
        {
            return null;
        }
        if (this.encoded != null)
        {
            return this.encoded;
        }
        return this.decoded;
    }

    private static void ValidateEncodedName(string name, bool allowNull)
    {
        if (!allowNull || (name != null))
        {
            try
            {
                XmlConvert.VerifyNCName(name);
            }
            catch (XmlException exception)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new ArgumentException(exception.Message, "name"));
            }
        }
    }

    // Properties
    internal string DecodedName
    {
        get
        {
            if (this.decoded == null)
            {
                this.decoded = NamingHelper.CodeName(this.encoded);
            }
            return this.decoded;
        }
    }

    internal string EncodedName
    {
        get
        {
            if (this.encoded == null)
            {
                this.encoded = NamingHelper.XmlName(this.decoded);
            }
            return this.encoded;
        }
    }

    private bool IsEmpty
    {
        get
        {
            return (string.IsNullOrEmpty(this.encoded) && string.IsNullOrEmpty(this.decoded));
        }
    }
}
