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
    
    public partial class Umowa_sprzedaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Umowa_sprzedaz()
        {
            this.Sprzedaz = new HashSet<Sprzedaz>();
        }
    
        public int ID_umowa_sprzedaz { get; set; }
        public int ID_oferta_handlowa { get; set; }
    
        public virtual Oferta_handlowa Oferta_handlowa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz> Sprzedaz { get; set; }
    }
}
