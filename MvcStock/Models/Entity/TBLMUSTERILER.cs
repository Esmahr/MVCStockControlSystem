//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStock.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLMUSTERILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMUSTERILER()
        {
            this.TBLSATISLARs = new HashSet<TBLSATISLAR>();
        }
    
        public int MUSTERIID { get; set; }

        [Required(ErrorMessage ="bu alan? bo? b?rakamazs?n?z")]
        [StringLength(50, ErrorMessage ="en fazla 50 karakterlik isim girin")]
        public string MUSTERIAD { get; set; }
        [Required(ErrorMessage = "bu alan? bo? b?rakamazs?n?z")]
        [StringLength(50, ErrorMessage = "en fazla 50 karakterlik soyad? girin")]

        public string MUSTERISOYAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATISLAR> TBLSATISLARs { get; set; }
    }
}
