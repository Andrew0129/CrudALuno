using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAluno.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudAluno.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(s => s.RA);
        }
    }
}
