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


public class FaultDescriptionCollection : Collection<FaultDescription>
{
    // Methods
    internal FaultDescriptionCollection()
    {
    }

    public FaultDescription Find(string action)
    {
        foreach (FaultDescription description in this)
        {
            if ((description != null) && (action == description.Action))
            {
                return description;
            }
        }
        return null;
    }

    public Collection<FaultDescription> FindAll(string action)
    {
        Collection<FaultDescription> collection = new Collection<FaultDescription>();
        foreach (FaultDescription description in this)
        {
            if ((description != null) && (action == description.Action))
            {
                collection.Add(description);
            }
        }
        return collection;
    }
}
