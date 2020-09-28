using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace studentApp
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}