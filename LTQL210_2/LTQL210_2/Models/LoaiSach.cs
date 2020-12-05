using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL210_2.Models
{
    [Table("LoaiSachs")]
    public class LoaiSach
    {
        [Key]
        public ICollection<Sach> Sach{ get; set; }
        public string TenLoaiSach { get; set; }

    }
}