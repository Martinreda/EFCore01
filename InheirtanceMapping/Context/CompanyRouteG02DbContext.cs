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

        #region 1- Table Per Concrete Type TPCT
        public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        #endregion
    }
}
