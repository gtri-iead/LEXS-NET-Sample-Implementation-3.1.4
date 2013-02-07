using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.CodeDom;
using System.Xml;
using System.Reflection;
using System.Collections.ObjectModel;

public class MessagePartDescriptionCollection : KeyedCollection<XmlQualifiedName, MessagePartDescription>
{
    // Methods
    internal MessagePartDescriptionCollection() : base(null, 4)
    {
    }

    protected override XmlQualifiedName GetKeyForItem(MessagePartDescription item)
    {
        return new XmlQualifiedName(item.Name, item.Namespace);
    }
}

