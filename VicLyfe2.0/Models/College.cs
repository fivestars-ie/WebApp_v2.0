namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("College")]
    public partial class College
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int College_id { get; set; }

        [Required]
        [StringLength(17)]
        public string Region_name { get; set; }

        [Required]
        [StringLength(20)]
        public string Suburb_name { get; set; }

        [Required]
        [StringLength(100)]
        public string Institution_name { get; set; }

        [Required]
        [StringLength(67)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(11)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(11)]
        public string Longitude { get; set; }

        [Required]
        [StringLength(12)]
        public string Area_type { get; set; }
    }
}
