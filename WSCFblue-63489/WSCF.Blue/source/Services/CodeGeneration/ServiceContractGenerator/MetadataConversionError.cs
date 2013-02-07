﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.ServiceModel;


public class MetadataConversionError
{
    // Fields
    private bool isWarning;
    private string message;

    // Methods
    public MetadataConversionError(string message) : this(message, false)
    {
    }

    public MetadataConversionError(string message, bool isWarning)
    {
        if (message == null)
        {
            throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("message");
        }
        this.message = message;
        this.isWarning = isWarning;
    }

    public override bool Equals(object obj)
    {
        MetadataConversionError error = obj as MetadataConversionError;
        if (error == null)
        {
            return false;
        }
        return ((error.IsWarning == this.IsWarning) && (error.Message == this.Message));
    }

    public override int GetHashCode()
    {
        return this.message.GetHashCode();
    }

    // Properties
    public bool IsWarning
    {
        get
        {
            return this.isWarning;
        }
    }

    public string Message
    {
        get
        {
            return this.message;
        }
    }
}

 

 
