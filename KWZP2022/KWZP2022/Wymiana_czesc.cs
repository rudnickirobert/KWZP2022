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
    
    public partial class Wymiana_czesc
    {
        public int ID_obsluga { get; set; }
        public int ID_maszyna_nr { get; set; }
        public int ID_czesc { get; set; }
    
        public virtual Czesc Czesc { get; set; }
        public virtual Maszyna_nr_seryjny Maszyna_nr_seryjny { get; set; }
        public virtual Obsluga Obsluga { get; set; }
    }
}
