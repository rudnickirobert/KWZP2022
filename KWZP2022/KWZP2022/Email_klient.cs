//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class Email_klient
    {
        public int ID_email_klient { get; set; }
        public int ID_klient { get; set; }
        public string Email { get; set; }
        public System.DateTime Data_od { get; set; }
        public Nullable<System.DateTime> Data_do { get; set; }
    
        public virtual Klient Klient { get; set; }
    }
}
