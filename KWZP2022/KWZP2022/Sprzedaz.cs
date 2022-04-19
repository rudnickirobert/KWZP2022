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
    
    public partial class Sprzedaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprzedaz()
        {
            this.Reklamacjas = new HashSet<Reklamacja>();
            this.Szczegoly_sprzedaz = new HashSet<Szczegoly_sprzedaz>();
        }
    
        public int ID_sprzedaz { get; set; }
        public int Nr_sprzedaz { get; set; }
        public System.DateTime Data_sprzedaz_poczatek { get; set; }
        public System.DateTime Data_sprzedaz_koniec { get; set; }
        public System.DateTime Termin_zaplata { get; set; }
        public int ID_forma_platnosc { get; set; }
        public int ID_umowa_sprzedaz { get; set; }
    
        public virtual Forma_platnosc Forma_platnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reklamacja> Reklamacjas { get; set; }
        public virtual Umowa_sprzedaz Umowa_sprzedaz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_sprzedaz> Szczegoly_sprzedaz { get; set; }
    }
}
