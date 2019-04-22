namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rent_id { get; set; }

        [Required]
        [StringLength(20)]
        public string Suburb_name { get; set; }

        [Required]
        [StringLength(17)]
        public string Region_name { get; set; }

        public int Unit_type { get; set; }

        public int Year { get; set; }

        [Required]
        [StringLength(5)]
        public string Average_rent { get; set; }
    }
}
