namespace LTQL210_2.Models
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

        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<LoaiSach> Loaisachs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);
            modelBuilder.Entity<Sach>()
                .Property(e => e.TenSach)
                .IsUnicode(true);
            modelBuilder.Entity<Sach>()
                .Property(e => e.NgayXuatBan)
                .IsUnicode(false);
            modelBuilder.Entity<Sach>()
                .Property(e => e.GiaSach)
                .IsUnicode(false);
            modelBuilder.Entity<LoaiSach>()
                .Property(e => e.TenLoaiSach)
                .IsUnicode(true);
        }
    }
}
