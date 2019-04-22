namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Points_Calculator
    {
        [Key]
        public DateTime Query_date { get; set; }

        [Required]
        [StringLength(50)]
        public string Age_group { get; set; }

        [Required]
        [StringLength(50)]
        public string Language_proficiency { get; set; }

        [Required]
        [StringLength(50)]
        public string Australian_study_requirement { get; set; }

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }

        [Required]
        [StringLength(50)]
        public string Doctrate_or_Master_by_research { get; set; }

        [Required]
        [StringLength(50)]
        public string Overseas_work_experience { get; set; }

        [Required]
        [StringLength(50)]
        public string Australian_work_experience { get; set; }

        [Required]
        [StringLength(50)]
        public string Partner_skills { get; set; }

        [Required]
        [StringLength(50)]
        public string Designated_language_skills { get; set; }

        public virtual Age Age { get; set; }

        public virtual Australian_experience Australian_experience { get; set; }

        public virtual Australian_study Australian_study { get; set; }

        public virtual Designated_Language Designated_Language { get; set; }

        public virtual Doctrate Doctrate { get; set; }

        public virtual Language_skills Language_skills { get; set; }

        public virtual Overseas_experience Overseas_experience { get; set; }

        public virtual Partner_level Partner_level { get; set; }

        public virtual Qualification_skills Qualification_skills { get; set; }
    }
}
