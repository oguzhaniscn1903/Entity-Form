//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Projesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_urun()
        {
            this.tbl_satis = new HashSet<tbl_satis>();
        }
    
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<int> KategoriId { get; set; }
    
        public virtual tbl_kategori tbl_kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_satis> tbl_satis { get; set; }
    }
}
