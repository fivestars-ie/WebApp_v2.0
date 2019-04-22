namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aggregate
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Suburb_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(17)]
        public string Region_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Unit_type { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(47)]
        public string Job_type { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Total_jobs { get; set; }

        public int? Total_hospitals { get; set; }

        public int? Total_parks { get; set; }

        public int? Total_colleges { get; set; }
    }
}
