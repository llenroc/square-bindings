﻿using System.Reflection;
using System.Runtime.InteropServices;
using Foundation;

// This attribute allows you to mark your assemblies as “safe to link”.
// When the attribute is present, the linker—if enabled—will process the assembly
// even if you’re using the “Link SDK assemblies only” option, which is the default for device builds.

[assembly: LinkerSafe]

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle ("Square.Aardvark")]
[assembly: AssemblyDescription ("")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("")]
[assembly: AssemblyProduct ("Square.Aardvark")]
[assembly: AssemblyCopyright ("Copyright © Square 2017")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]
[assembly: ComVisible (false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion ("3.0.0.0")]
[assembly: AssemblyFileVersion ("3.1.0.0")]
