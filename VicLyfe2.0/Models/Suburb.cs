namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suburb")]
    public partial class Suburb
    {
        [Key]
        [StringLength(20)]
        public string city { get; set; }

        [Required]
        [StringLength(17)]
        public string Region { get; set; }

        public int means { get; set; }

        [Column(TypeName = "numeric")]
        public decimal area { get; set; }
    }
}
