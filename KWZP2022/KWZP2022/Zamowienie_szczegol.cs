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
    
    public partial class Zamowienie_szczegol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienie_szczegol()
        {
            this.Wytwarzanies = new HashSet<Wytwarzanie>();
        }
    
        public int ID_zamowienie_szczegol { get; set; }
        public int ID_zamowienie { get; set; }
        public int ID_produkt { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Produkt Produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wytwarzanie> Wytwarzanies { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
