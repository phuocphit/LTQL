using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL249.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        public string NgayTao { get; set; }
        public string MaKhachHang { get; set; }
    }
}