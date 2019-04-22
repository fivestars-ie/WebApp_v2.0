namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Job_id { get; set; }

        [Required]
        [StringLength(20)]
        public string Suburb_name { get; set; }

        [Required]
        [StringLength(17)]
        public string Region_name { get; set; }

        [Required]
        [StringLength(47)]
        public string Job_type { get; set; }

        public int Year { get; set; }

        public int Total_jobs { get; set; }
    }
}
