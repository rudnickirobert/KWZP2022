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
    
    public partial class Sklad_stanowisko_produkcyjne_narzedzie
    {
        public int ID_sklad_stanowisko_produkcyjne_narzedzie { get; set; }
        public int ID_stanowisko_produkcyjne { get; set; }
        public int ID_narzedzie { get; set; }
        public int Liczba { get; set; }
    
        public virtual Narzedzie Narzedzie { get; set; }
        public virtual Stanowisko_produkcyjne Stanowisko_produkcyjne { get; set; }
    }
}