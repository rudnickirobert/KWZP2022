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
    
    public partial class Reklamacja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reklamacja()
        {
            this.Zwrots = new HashSet<Zwrot>();
        }
    
        public int ID_reklamacja { get; set; }
        public int ID_pracownik { get; set; }
        public int ID_sprzedaz { get; set; }
        public System.DateTime Data_reklamacja { get; set; }
        public string Opis_reklamacja { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Sprzedaz Sprzedaz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zwrot> Zwrots { get; set; }
    }
}
