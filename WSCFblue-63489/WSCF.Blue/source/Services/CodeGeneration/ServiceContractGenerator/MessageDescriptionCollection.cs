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


public class MessageDescriptionCollection : Collection<MessageDescription>
{
    // Methods
    internal MessageDescriptionCollection()
    {
    }

    public MessageDescription Find(string action)
    {
        foreach (MessageDescription description in this)
        {
            if ((description != null) && (action == description.Action))
            {
                return description;
            }
        }
        return null;
    }

    public Collection<MessageDescription> FindAll(string action)
    {
        Collection<MessageDescription> collection = new Collection<MessageDescription>();
        foreach (MessageDescription description in this)
        {
            if ((description != null) && (action == description.Action))
            {
                collection.Add(description);
            }
        }
        return collection;
    }
}
