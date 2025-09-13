using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment.Context
{
    internal class ITIDbcontext  : DbContext
    {
        public ITIDbcontext() :base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI02;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //base.OnModelCreating(modelBuilder);

        }
        public DbSet<Course> courses { get; set; }
       public DbSet<Course_Inst> course_Insts { get; set; }
       public DbSet<Department> departments { get; set; }
       public DbSet<Instructor> instructors { get; set; }
       public DbSet<Stud_Course> stud_Courses { get; set; }
       public DbSet<Student> students { get; set; }
       public DbSet<Topic> topics { get; set; }

    }
}
