﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Server.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;body&gt;
        ///
        ///&lt;form action=&quot;https://www.paypal.com/cgi-bin/webscr&quot; method=&quot;post&quot; target=&quot;_top&quot;&gt;
        ///&lt;input type=&quot;hidden&quot; name=&quot;custom&quot; value=&quot;$CHARACTERNAME$&quot;&gt;
        ///&lt;input type=&quot;hidden&quot; name=&quot;cmd&quot; value=&quot;_s-xclick&quot;&gt;
        ///&lt;input type=&quot;hidden&quot; name=&quot;hosted_button_id&quot; value=&quot;S8QAMCYTGM4SC&quot;&gt;
        ///&lt;table&gt;
        ///&lt;tr&gt;&lt;td&gt;&lt;input type=&quot;hidden&quot; name=&quot;on0&quot; value=&quot;Game Gold Quantity&quot;&gt;Game Gold Quantity&lt;/td&gt;&lt;/tr&gt;&lt;tr&gt;&lt;td&gt;&lt;select name=&quot;os0&quot;&gt;
        ///	&lt;option value=&quot;500 Gold&quot;&gt;500 Gold £5.00 GBP&lt;/option&gt;
        ///	&lt;option value=&quot;1030 Gold (+3%)&quot;&gt;1030 Gol [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BuyGameGold {
            get {
                return ResourceManager.GetString("BuyGameGold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;body&gt;
        ///Failed to buy GameGold. Character Not Found.
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string CharacterNotFound {
            get {
                return ResourceManager.GetString("CharacterNotFound", resourceCulture);
            }
        }
    }
}
