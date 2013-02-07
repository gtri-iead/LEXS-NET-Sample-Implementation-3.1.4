using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("WSCF Environment Helper")]
[assembly: AssemblyDescription("Helpers for registering and installing WSCF.")]

// Apply .NET Framework design guideline rules
[assembly: FileIOPermission(SecurityAction.RequestMinimum, Unrestricted=true)]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]