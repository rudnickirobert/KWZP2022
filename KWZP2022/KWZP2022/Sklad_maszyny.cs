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
    
    public partial class Sklad_maszyny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sklad_maszyny()
        {
            this.Wymiana_czesc = new HashSet<Wymiana_czesc>();
        }
    
        public int ID_sklad_maszyny { get; set; }
        public int ID_rodzaj_maszyna { get; set; }
        public int ID_czesc { get; set; }
        public int Liczba_czesci { get; set; }
    
        public virtual Czesc Czesc { get; set; }
        public virtual Rodzaj_maszyna Rodzaj_maszyna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wymiana_czesc> Wymiana_czesc { get; set; }
    }
}
