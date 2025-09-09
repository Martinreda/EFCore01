using Demo.Context;
using Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session01
            #region Entity Framework Core

            /*
             * Features :-
             * -------------------------------
             * - Object Relational Mapper (ORM) => Fully ORM
             * - Auto Tracker
             * - Support Migrations
             * - Support LINQ
             * - Cross Platform
             * - Support Multiple Databases
             */

            #endregion

            #region ADO.NET

            /*
             * Features :-
             * -------------------------------
             * - Low Level Framework
             * - No Tracking
             * - Manual Connection
             * - Direct Access to SQL
             */

            #endregion


            #region Dapper

            /*
             * Features :-
             * -------------------------------
             * - Lightweight for Simple, Small Projects
             * - No Tracker
             * - No Migrations
             * - Simple API (Dapper)
             * - Faster
             * - Easy to Use
             * - Micro ORM
             * - Limited Features
             */

            #endregion

            #region DbContext

            //CompanyDBcontext dBcontext = new CompanyDBcontext();
            //open Connection With DataBase 

            //close Connection
            //try
            //{


            //}
            //finally
            //{
            //    dBcontext.Dispose();
            //}

            //using CompanyDBcontext dBcontext = new CompanyDBcontext();

            // لتطبيق الـ Migrations
            // لازم تنزل الباكدج دي:
            // Microsoft.EntityFrameworkCore.Tools


            //to applAy database in sql server
            // update daatabase

            #endregion
            #endregion

            #region Session 02 

            #region Query object Model 
            //To add Data in Databse 
            //Connect With databas 
            using CompanyDBcontext dBcontext = new CompanyDBcontext();
            Employee emp01 = new Employee()
            {
                /*id = 1*/ 
                Name = "martin",
                salary = 20000,
                Age = 20 

            };
            Console.WriteLine(dBcontext.Entry<Employee>(emp01).State); //Detatched

            //Add Emp01 to table emp in dadtabase
            //01
            dBcontext.Employees.Add(emp01);

            ////02
            //dBcontext.Set<Employee>().Add(emp01);

            ////03
            //dBcontext.Add(emp01);

            Console.WriteLine(dBcontext.Entry<Employee>(emp01).State); /*Auto Trucker*/
            //Save changes --- Apply Databas 

            try
            {
                dBcontext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("DbUpdateException: " + ex.Message);
                Console.WriteLine("InnerException: " + ex.InnerException?.Message);
            }

            #endregion
            #endregion
        }
    }
}
