﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPv4Check.Resources {
    using System;
    
    
    /// <summary>
    ///   Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.
    /// </summary>
    // Tato třída byla automaticky generována třídou StronglyTypedResourceBuilder
    // pomocí nástroje podobného aplikaci ResGen nebo Visual Studio.
    // Chcete-li přidat nebo odebrat člena, upravte souboru .ResX a pak znovu spusťte aplikaci ResGen
    // s parametrem /str nebo znovu sestavte projekt aplikace Visual Studio.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Language {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Language() {
        }
        
        /// <summary>
        ///   Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IPv4Check.Resources.Language", typeof(Language).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
        ///   vyhledání prostředků pomocí třídy prostředků se silnými typy.
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
        ///   Vyhledá lokalizovaný řetězec podobný Invalid (empty) input..
        /// </summary>
        internal static string msg_invalidEmpty {
            get {
                return ResourceManager.GetString("msg_invalidEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Address is NOT valid IPv4!..
        /// </summary>
        internal static string msg_isNotValid {
            get {
                return ResourceManager.GetString("msg_isNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Address IS valid IPv4!..
        /// </summary>
        internal static string msg_isValid {
            get {
                return ResourceManager.GetString("msg_isValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Is your numbers combination valid for a IPV4 address?.
        /// </summary>
        internal static string WelcomeMessage {
            get {
                return ResourceManager.GetString("WelcomeMessage", resourceCulture);
            }
        }
    }
}
