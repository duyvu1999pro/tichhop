namespace Admin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANTRI")]
    public partial class QUANTRI
    {
        [Key]
        public int MaQT { get; set; }

        [StringLength(255)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }
    }
}
