namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Partner_level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner_level()
        {
            Points_Calculator = new HashSet<Points_Calculator>();
        }

        [Key]
        [StringLength(50)]
        public string Partner_skills { get; set; }

        public int Partner_points { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Points_Calculator> Points_Calculator { get; set; }
    }
}
