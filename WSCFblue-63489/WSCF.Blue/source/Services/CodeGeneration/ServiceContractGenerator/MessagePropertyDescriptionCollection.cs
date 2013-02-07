
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


public class MessagePropertyDescriptionCollection : KeyedCollection<string, MessagePropertyDescription>
{
    // Methods
    internal MessagePropertyDescriptionCollection() : base(null, 4)
    {
    }

    protected override string GetKeyForItem(MessagePropertyDescription item)
    {
        return item.Name;
    }
}
