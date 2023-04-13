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
        public virtual DbSet<AdminAccount> AdminAccounts { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .Property(e => e.role_name)
                .IsFixedLength();
            modelBuilder.Entity<AdminAccount>()
                .Property(e => e.user_name)
                .IsFixedLength();
            modelBuilder.Entity<AdminAccount>()
                .Property(e => e.user_pass)
                .IsFixedLength();
        }
    }
}
