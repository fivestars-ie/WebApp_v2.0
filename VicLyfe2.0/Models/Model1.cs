namespace VicLyfe2._0.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Age> Ages { get; set; }
        public virtual DbSet<Australian_experience> Australian_experience { get; set; }
        public virtual DbSet<Australian_study> Australian_study { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<College_count> College_count { get; set; }
        public virtual DbSet<Designated_Language> Designated_Language { get; set; }
        public virtual DbSet<Doctrate> Doctrates { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Hospital_count> Hospital_count { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Job_type> Job_type { get; set; }
        public virtual DbSet<Language_skills> Language_skills { get; set; }
        public virtual DbSet<Overseas_experience> Overseas_experience { get; set; }
        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<Park_count> Park_count { get; set; }
        public virtual DbSet<Partner_level> Partner_level { get; set; }
        public virtual DbSet<Points_Calculator> Points_Calculator { get; set; }
        public virtual DbSet<Preference_Rating> Preference_Rating { get; set; }
        public virtual DbSet<Qualification_skills> Qualification_skills { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Selected_region> Selected_region { get; set; }
        public virtual DbSet<Suburb> Suburbs { get; set; }
        public virtual DbSet<Unit_type> Unit_type { get; set; }
        public virtual DbSet<User_preference> User_preference { get; set; }
        public virtual DbSet<Aggregate> Aggregates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Age>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Age)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Australian_experience>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Australian_experience)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Australian_study>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Australian_study)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Designated_Language>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Designated_Language)
                .HasForeignKey(e => e.Designated_language_skills)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctrate>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Doctrate)
                .HasForeignKey(e => e.Doctrate_or_Master_by_research)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job_type>()
                .HasMany(e => e.User_preference)
                .WithRequired(e => e.Job_type)
                .HasForeignKey(e => e.Job_field_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job_type>()
                .HasMany(e => e.User_preference1)
                .WithRequired(e => e.Job_type1)
                .HasForeignKey(e => e.Job_field_2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language_skills>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Language_skills)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Overseas_experience>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Overseas_experience)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Partner_level>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Partner_level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Preference_Rating>()
                .HasMany(e => e.User_preference)
                .WithRequired(e => e.Preference_Rating)
                .HasForeignKey(e => e.Do_you_prefer_Parks_and_Reserves)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Preference_Rating>()
                .HasMany(e => e.User_preference1)
                .WithRequired(e => e.Preference_Rating1)
                .HasForeignKey(e => e.Educational_Institutes_Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Preference_Rating>()
                .HasMany(e => e.User_preference2)
                .WithRequired(e => e.Preference_Rating2)
                .HasForeignKey(e => e.Hospital_Service_Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Preference_Rating>()
                .HasMany(e => e.User_preference3)
                .WithRequired(e => e.Preference_Rating3)
                .HasForeignKey(e => e.Job_Requirement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Qualification_skills>()
                .HasMany(e => e.Points_Calculator)
                .WithRequired(e => e.Qualification_skills)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .HasOptional(e => e.Selected_region)
                .WithRequired(e => e.Region);

            modelBuilder.Entity<Suburb>()
                .Property(e => e.area)
                .HasPrecision(9, 1);

            modelBuilder.Entity<Unit_type>()
                .HasMany(e => e.User_preference)
                .WithRequired(e => e.Unit_type)
                .WillCascadeOnDelete(false);
        }
    }
}
