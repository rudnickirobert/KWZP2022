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
    
    public partial class Dane_adresowe_producent
    {
        public int ID_dane_adresowe_producent { get; set; }
        public int ID_producent { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public int Nr_budynku { get; set; }
        public string Kod_pocztowy { get; set; }
    
        public virtual Producent Producent { get; set; }
    }
}
