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
    
    public partial class v_Oferta_handlowa
    {
        public int Numer_zamówienia { get; set; }
        public int Numer_oferty { get; set; }
        public string Status_oferty { get; set; }
        public int Okres_gwarancji { get; set; }
        public string Opis_gwarancji { get; set; }
        public Nullable<int> Cena { get; set; }
        public System.DateTime Termin_realizacji { get; set; }
        public string Nazwisko_pracownika { get; set; }
        public string Imię_pracownika { get; set; }
    }
}
