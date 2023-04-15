using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace model.Framework
{
    public partial class ThiTracNgiem : DbContext
    {
        public ThiTracNgiem()
            : base("name=ThiTracNgiem")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.firstName)
                .IsFixedLength();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Level>()
                .Property(e => e.level_name)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.role_name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.firstName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
