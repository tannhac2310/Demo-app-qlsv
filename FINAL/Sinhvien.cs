namespace FINAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sinhvien")]
    public partial class Sinhvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinhvien()
        {
            DiemHPs = new HashSet<DiemHP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSV { get; set; }

        [StringLength(100)]
        public string TenSV { get; set; }

        [StringLength(50)]
        public string Ngaysinh { get; set; }

        [StringLength(50)]
        public string Gioitinh { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(20)]
        public string Malop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemHP> DiemHPs { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
