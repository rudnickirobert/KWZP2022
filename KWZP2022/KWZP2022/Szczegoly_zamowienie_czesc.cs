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
    
    public partial class Szczegoly_zamowienie_czesc
    {
        public int ID_zamowienie_czesc { get; set; }
        public int ID_czesc { get; set; }
        public int ID_producent { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }
    
        public virtual Czesc Czesc { get; set; }
        public virtual Producent Producent { get; set; }
        public virtual Zamowienie_czesc Zamowienie_czesc { get; set; }
    }
}
