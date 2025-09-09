using System;
using System.Collections.Generic;
using System.Linq;
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
        //if you want a model turned into Table in DataBase
        // You must use Dbset<> 
        public DbSet<Employee>Employees { get; set; } 
        public DbSet<User>Users { get; set; } 
    }
}
