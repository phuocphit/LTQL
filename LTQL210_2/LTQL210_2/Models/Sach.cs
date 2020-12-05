using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL210_2.Models
{
    [Table("Sachs")]
    public class Sach
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public LoaiSach MaLoaiSach { get; set; }
        public string NgayXuatBan { get; set; }
        public string GiaSach { get; set; }
        public string MaTacGia { get; set; }

    }
}