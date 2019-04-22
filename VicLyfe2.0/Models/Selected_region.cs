namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Selected_region
    {
        [Key]
        [StringLength(17)]
        public string Region_name { get; set; }

        public virtual Region Region { get; set; }
    }
}
