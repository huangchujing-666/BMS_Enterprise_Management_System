﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbxdata.model.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.1.124;Initial Catalog=pbxDB;Persist Security Info=True;User I" +
        "D=sa;Password=bms123456")]
        //[global::System.Configuration.DefaultSettingValueAttribute("data source=rdsr5tbb7cta2rjoun2qa.sqlserver.rds.aliyuncs.com,3433;initial catalog=db_bms;user id=bms_sa;pwd=bms_sa;multipleactive" +
        //    "resultsets=true;application name=entityframework")]
        public string pbxDBConnectionString
        {
            get
            {
                return ((string)(this["pbxDBConnectionString"]));
            }
        }

    }
}
