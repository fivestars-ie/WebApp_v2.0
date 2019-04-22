namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Park")]
    public partial class Park
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Park_id { get; set; }

        [Required]
        [StringLength(51)]
        public string name { get; set; }

        [Required]
        [StringLength(45)]
        public string Suburb_name { get; set; }

        [Required]
        [StringLength(11)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(11)]
        public string longitude { get; set; }
    }
}
