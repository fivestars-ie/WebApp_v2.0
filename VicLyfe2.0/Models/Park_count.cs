namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Park_count
    {
        [Key]
        [StringLength(45)]
        public string Suburb_name { get; set; }

        [StringLength(17)]
        public string Region { get; set; }

        public int? Total_parks { get; set; }
    }
}
