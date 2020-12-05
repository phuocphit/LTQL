namespace LTQL210.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LTQLDBCONTEXT : DbContext
    {
        public LTQLDBCONTEXT()
            : base("name=LTQLDBCONTEXT")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .Property(e => e.MaLoaiSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaLoaiSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaTacGia)
                .IsUnicode(false);
        }
    }
}
