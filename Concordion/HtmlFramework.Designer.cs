﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Concordion {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class HtmlFramework {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HtmlFramework() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Concordion.HtmlFramework", typeof(HtmlFramework).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to * {
        ///  font-family: Arial;
        ///}
        ///body {
        ///  padding: 32px;  
        ///}
        ///pre {
        ///  padding: 6px 28px 6px 28px;
        ///  background-color: #E8EEF7;
        ///}
        ///pre, pre *, code, kbd {
        ///  font-family: Courier New, Courier;
        ///  font-size: 10pt;
        ///}
        ///h1, h1 * {
        ///  font-size: 24pt;	
        ///}
        ///p, td, th, li, .breadcrumbs {
        ///  font-size: 10pt;
        ///}
        ///p, li {
        ///  line-height: 140%;
        ///}
        ///table {
        ///  border-collapse: collapse;
        ///  empty-cells: show;
        ///  margin: 8px 0px 8px 0px;
        ///}
        ///th, td {
        ///  border: 1px solid black;
        ///  padding: 3px;
        ///}
        ///td {
        ///  background- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EMBEDDED_STYLESHEET_RESOURCE {
            get {
                return ResourceManager.GetString("EMBEDDED_STYLESHEET_RESOURCE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://www.concordion.org/2007/concordion.
        /// </summary>
        internal static string NAMESPACE_CONCORDION_2007 {
            get {
                return ResourceManager.GetString("NAMESPACE_CONCORDION_2007", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap SOURCE_LOGO_RESOURCE_PATH {
            get {
                object obj = ResourceManager.GetObject("SOURCE_LOGO_RESOURCE_PATH", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Stack Trace Toggling */
        ///
        ///function getElementById(id) {
        ///  var element;
        ///
        ///  if (document.getElementById) { // standard
        ///    return document.getElementById(id);
        ///  } else if (document.all) { // old IE versions
        ///    return document.all[id];
        ///  } else if (document.layers) { // nn4
        ///    return document.layers[id];
        ///  }
        ///  alert(&quot;Sorry, but your web browser is not supported by Concordion.&quot;);
        ///}
        ///
        ///function isVisible(element) {
        ///  return element.style.display;
        ///}
        ///
        ///function makeVisible(element) {
        ///  element [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TOGGLING_SCRIPT_RESOURCE {
            get {
                return ResourceManager.GetString("TOGGLING_SCRIPT_RESOURCE", resourceCulture);
            }
        }
    }
}
