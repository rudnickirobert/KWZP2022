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
    
    public partial class Szczegoly_zamowienia
    {
        public int ID_szczegoly_zamowienie { get; set; }
        public int ID_zamowienie { get; set; }
        public int ID_produkt { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Produkt Produkt { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}