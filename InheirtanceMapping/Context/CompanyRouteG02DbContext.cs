using InheirtanceMapping.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheirtanceMapping.Context
{
    internal class CompanyRouteG02DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyRouteG02;Trusted_Connection = true ; TrustServerCertificate = true;  "); 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();

            modelBuilder.Entity<Employee>()
                .HasDiscriminator<string>("EmployeeType")
                .HasValue<FullTimeEmployee>("FTE")
                .HasValue<PartTimeEmployee>("PTE");
        }

        #region 1- Table Per Concrete Type TPCT
        //public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        #endregion

        #region 2- Table Per Heirarcy TPH
        public DbSet<Employee> employees { get; set; }
        //public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        #endregion
    }
}
