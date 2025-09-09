using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Demo.Model;
using Microsoft.EntityFrameworkCore;


namespace Demo.Context
{
    internal class CompanyDBcontext : DbContext
    {
        //when you create new class as new Dbcintext
        //you must downloald this Pakage=> Microsoft.EntityFrameWork.sqlserver
        public CompanyDBcontext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Conect between console App => Database
            // connection string => serverName , Database Name
            optionsBuilder.UseSqlServer("Server = . ; Database = MyCompany02; Trusted_Connection = true ; TrustServerCertificate = true");

        }

        #region Fluent APIS
        // Apply mapping with fluent APIS you must Ovverride (on MOdel)
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //modelBuilder.Entity<Employee>().HasKey(E => E.id);
        //// Constrain For PK 
        ////modelBuilder.Entity<Employee>().Property(E => E.id)
        ////    .UseIdentityColumn(10 , 10); //Add constrain 

        //////Deny Constrain 
        ////modelBuilder.Entity<Employee>()
        ////    .Property(E => E.id)
        ////    .ValueGeneratedNever();

        //modelBuilder.Entity<Employee>().Property(E => E.Name)
        //    .HasColumnName("Emp_Name")
        //    .HasColumnType("varchar (50)")
        //    .HasMaxLength(50)
        //    .IsRequired(false); // Not allow null
        //// By defult == True Donnot allow null



        // another Way 

        //modelBuilder.Entity<Employee>(E =>
        //{
        //    E.HasKey(E => E.id);
        //    E.Property(E => E.Name)
        //    .HasColumnName("Emp_Name")
        //    .HasColumnType("varchar (50)")
        //    .HasMaxLength(50)
        //    .IsRequired(false);

        //    E.Property(E => E.salary).
        //    HasDefaultValue(80000);

        //});
        // }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        //if you want a model turned into Table in DataBase
        // You must use Dbset<> 
        public DbSet<Employee>Employees { get; set; } 
        public DbSet<User>Users { get; set; } 
    }
}
