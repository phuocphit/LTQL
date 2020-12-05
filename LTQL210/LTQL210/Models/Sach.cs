namespace LTQL210.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [Key]
        [StringLength(50)]
        public string MaSach { get; set; }

        [StringLength(50)]
        public string TenSach { get; set; }

        [StringLength(50)]
        public string MaLoaiSach { get; set; }

        public DateTime? NgayXuatBan { get; set; }

        public int? GiaSach { get; set; }

        [StringLength(50)]
        public string MaTacGia { get; set; }

        public virtual LoaiSach LoaiSach { get; set; }
    }
}
