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
    
    public partial class Stanowisko_produkcyjne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stanowisko_produkcyjne()
        {
            this.Obslugas = new HashSet<Obsluga>();
            this.Proces_wytwarzanie_polprodukt = new HashSet<Proces_wytwarzanie_polprodukt>();
            this.Proces_wytwarzanie_produkt = new HashSet<Proces_wytwarzanie_produkt>();
            this.Sklad_stanowisko_produkcyjne_maszyna = new HashSet<Sklad_stanowisko_produkcyjne_maszyna>();
            this.Sklad_stanowisko_produkcyjne_narzedzie = new HashSet<Sklad_stanowisko_produkcyjne_narzedzie>();
        }
    
        public int ID_stanowisko_produkcyjne { get; set; }
        public int ID_nazwa_stanowiska { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obsluga> Obslugas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_wytwarzanie_polprodukt> Proces_wytwarzanie_polprodukt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_wytwarzanie_produkt> Proces_wytwarzanie_produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_stanowisko_produkcyjne_maszyna> Sklad_stanowisko_produkcyjne_maszyna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_stanowisko_produkcyjne_narzedzie> Sklad_stanowisko_produkcyjne_narzedzie { get; set; }
        public virtual Slownik_stanowisko Slownik_stanowisko { get; set; }
    }
}
