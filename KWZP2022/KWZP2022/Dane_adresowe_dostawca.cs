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
    
    public partial class Dane_adresowe_dostawca
    {
        public int ID_dane_adresowe_dostawca { get; set; }
        public int ID_dostawca { get; set; }
        public int Miejscowosc { get; set; }
        public int Ulica { get; set; }
        public int Nr_budynku { get; set; }
        public int Kod_pocztowy { get; set; }
    
        public virtual Dostawca Dostawca { get; set; }
    }
}
