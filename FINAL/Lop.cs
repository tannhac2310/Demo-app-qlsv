namespace FINAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            Sinhviens = new HashSet<Sinhvien>();
        }

        [Key]
        [StringLength(20)]
        public string Malop { get; set; }

        [StringLength(50)]
        public string Tenlop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinhvien> Sinhviens { get; set; }
    }
}
