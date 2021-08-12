namespace FINAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Monhoc")]
    public partial class Monhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monhoc()
        {
            DiemHPs = new HashSet<DiemHP>();
        }

        [Key]
        [StringLength(20)]
        public string MaMH { get; set; }

        [StringLength(50)]
        public string TenMH { get; set; }

        public int? SoTC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemHP> DiemHPs { get; set; }
    }
}
