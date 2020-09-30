namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hang hoa")]
    public partial class hang_hoa
    {
        [Key]
        [StringLength(50)]
        public string mahang { get; set; }

        [StringLength(50)]
        public string tenhang { get; set; }

        [StringLength(50)]
        public string sodienthoai { get; set; }
    }
}
