namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class College_count
    {
        [Key]
        [StringLength(50)]
        public string City { get; set; }

        [StringLength(17)]
        public string Region { get; set; }

        public int? Total_colleges { get; set; }
    }
}
