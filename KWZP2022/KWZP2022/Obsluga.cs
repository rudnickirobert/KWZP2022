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
    
    public partial class Obsluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obsluga()
        {
            this.Wymiana_czesc = new HashSet<Wymiana_czesc>();
        }
    
        public int ID_obsluga { get; set; }
        public int ID_pracownik { get; set; }
        public int ID_rodzaj_obslugi { get; set; }
        public System.DateTime Data_od { get; set; }
        public Nullable<System.DateTime> Data_do { get; set; }
        public string Uwagi { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Rodzaj_obslugi Rodzaj_obslugi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wymiana_czesc> Wymiana_czesc { get; set; }
    }
}
