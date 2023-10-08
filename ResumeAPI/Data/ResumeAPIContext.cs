using Microsoft.EntityFrameworkCore;
using ResumeAPI.Models;

namespace ResumeAPI.Data
{
    public class ResumeAPIContext : DbContext
    {
        public ResumeAPIContext(DbContextOptions<ResumeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ResumeAPI.Models.Experiences> Experiences { get; set; }
        public DbSet<ResumeAPI.Models.Educations> Educations { get; set; }
        public DbSet<ResumeAPI.Models.Certifications> Certifications { get; set; }
        public DbSet<ResumeAPI.Models.Projects> Projects { get; set; }
        public DbSet<ResumeAPI.Models.Contacts> Contacts { get; set; }
        public DbSet<ResumeAPI.Models.Comments> Comments { get; set; }
        public DbSet<ResumeAPI.Models.Resume> Resume { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Resume>()
                        .Property(r => r.Id)
                        .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Experiences>()
                        .Property(r => r.ExperienceId)
                        .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Educations>()
                        .Property(r => r.EducationId)
                        .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Certifications>()
                        .Property(r => r.CertificationId)
                        .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Projects>()
                        .Property(r => r.ProjectId)
                        .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Contacts>()
                        .Property(r => r.ContactId)
                        .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Comments>()
                        .Property(r => r.CommentId)
                        .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Educations>()
                        .Property(r => r.Created_at)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Experiences>()
                        .Property(r => r.Created_at)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Projects>()
                        .Property(r => r.Created_at)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Contacts>()
                        .Property(r => r.Created_at)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Comments>()
                        .Property(r => r.Created_at)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }

    }
}
