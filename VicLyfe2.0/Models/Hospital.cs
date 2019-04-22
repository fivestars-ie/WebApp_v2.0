namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hospital")]
    public partial class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Hospital_id { get; set; }

        [Required]
        [StringLength(70)]
        public string Hospital_name { get; set; }

        [Required]
        [StringLength(7)]
        public string Type { get; set; }

        [Required]
        [StringLength(21)]
        public string suburb_name { get; set; }

        public int Postcode { get; set; }

        [Required]
        [StringLength(17)]
        public string Region_name { get; set; }
    }
}
