﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.Admin.Api.Dao.GroupDomain {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GroupDomainDaoResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal GroupDomainDaoResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.Admin.Api.Dao.GroupDomain.GroupDomainDaoResources", typeof(GroupDomainDaoResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to DELETE FROM group_domain_mapping 
        ///WHERE (group_id, domain_id) 
        ///IN (.
        /// </summary>
        public static string DeleteGroupDomain {
            get {
                return ResourceManager.GetString("DeleteGroupDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to (@a{0},@b{0}).
        /// </summary>
        public static string DeleteGroupDomainValueFormatString {
            get {
                return ResourceManager.GetString("DeleteGroupDomainValueFormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to INSERT INTO group_domain_mapping
        ///(group_id,
        ///domain_id)
        ///VALUES.
        /// </summary>
        public static string InsertGroupDomain {
            get {
                return ResourceManager.GetString("InsertGroupDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to (@a{0},@b{0}).
        /// </summary>
        public static string InsertGroupDomainValueFormatString {
            get {
                return ResourceManager.GetString("InsertGroupDomainValueFormatString", resourceCulture);
            }
        }
    }
}