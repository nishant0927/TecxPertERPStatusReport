//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecxPertERPStatusReport.WebApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSPL_BALANCE_SHEET_PERFORMA_GL_MAIN
    {
        public int SNO { get; set; }
        public string Main_GL_Account { get; set; }
    
        public virtual TSPL_ACCOUNT_MAIN_GL_ACCOUNT TSPL_ACCOUNT_MAIN_GL_ACCOUNT { get; set; }
    }
}
