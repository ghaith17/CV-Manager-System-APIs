using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Databases.Models
{
    public partial class RepositoryContext :DbContext
    {
        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CV> CV { get; set; }
        public virtual DbSet<Experience_Information> Experience_Information { get; set; }
        public virtual DbSet<Personal_Information> Personal_Information { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CV>().ToTable("CV", "dbo");
            modelBuilder.Entity<Experience_Information>().ToTable("Experience_Information", "dbo");
            modelBuilder.Entity<Personal_Information>().ToTable("Personal_Information","dbo");

          


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
