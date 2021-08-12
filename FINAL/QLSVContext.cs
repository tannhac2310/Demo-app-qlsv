using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FINAL
{
    public partial class QLSVContext : DbContext
    {
        public QLSVContext()
            : base("name=QLSVContext")
        {
        }

        public virtual DbSet<DiemHP> DiemHPs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Monhoc> Monhocs { get; set; }
        public virtual DbSet<Sinhvien> Sinhviens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Monhoc>()
                .HasMany(e => e.DiemHPs)
                .WithRequired(e => e.Monhoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sinhvien>()
                .HasMany(e => e.DiemHPs)
                .WithRequired(e => e.Sinhvien)
                .WillCascadeOnDelete(false);
        }
    }
}
