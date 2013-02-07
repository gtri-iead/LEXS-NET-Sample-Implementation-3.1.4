using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;


public class MessagePropertyDescription : MessagePartDescription
{
    // Methods
    internal MessagePropertyDescription(MessagePropertyDescription other) : base(other)
    {
    }

    public MessagePropertyDescription(string name) : base(name, "")
    {
    }

    internal override MessagePartDescription Clone()
    {
        return new MessagePropertyDescription(this);
    }
}
