namespace VicLyfe2._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_preference
    {
        [Key]
        public DateTime User_input_time { get; set; }

        public int Expected_Weekly_Rent { get; set; }

        [Required]
        [StringLength(50)]
        public string Number_of_bedrooms { get; set; }

        [Required]
        [StringLength(50)]
        public string Job_field_1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Job_field_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Job_Requirement { get; set; }

        [Required]
        [StringLength(50)]
        public string Hospital_Service_Requirement { get; set; }

        [Required]
        [StringLength(50)]
        public string Do_you_prefer_Parks_and_Reserves { get; set; }

        [Required]
        [StringLength(50)]
        public string Educational_Institutes_Requirement { get; set; }

        public virtual Job_type Job_type { get; set; }

        public virtual Job_type Job_type1 { get; set; }

        public virtual Preference_Rating Preference_Rating { get; set; }

        public virtual Preference_Rating Preference_Rating1 { get; set; }

        public virtual Preference_Rating Preference_Rating2 { get; set; }

        public virtual Preference_Rating Preference_Rating3 { get; set; }

        public virtual Unit_type Unit_type { get; set; }
    }
}
