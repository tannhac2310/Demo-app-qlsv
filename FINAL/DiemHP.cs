namespace FINAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemHP")]
    public partial class DiemHP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaMH { get; set; }

        public double? Diem { get; set; }

        public virtual Monhoc Monhoc { get; set; }

        public virtual Sinhvien Sinhvien { get; set; }
    }
}
