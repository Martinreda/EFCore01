using Demo.Context;
using Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDBcontext dBcontext = new CompanyDBcontext();

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

            #region Add New Rec
            //Employee emp01 = new Employee()
            //{
            //    /*id = 1*/ 
            //    Name = "martin",
            //    salary = 20000,
            //    Age = 20 

            //};
            //Console.WriteLine(dBcontext.Entry<Employee>(emp01).State); //Detatched

            ////Add Emp01 to table emp in dadtabase
            ////01
            //dBcontext.Employees.Add(emp01);

            //////02
            ////dBcontext.Set<Employee>().Add(emp01);

            //////03
            ////dBcontext.Add(emp01);

            //Console.WriteLine(dBcontext.Entry<Employee>(emp01).State); /*Auto Trucker*/
            ////Save changes --- Apply Databas 

            //try
            //{
            //    dBcontext.SaveChanges();
            //}
            //catch (DbUpdateException ex)
            //{
            //    Console.WriteLine("DbUpdateException: " + ex.Message);
            //    Console.WriteLine("InnerException: " + ex.InnerException?.Message);
            //}

            #endregion

            #region Select --- Get Data From Table 
            //var result = dBcontext.Employees.Where(E => E.id == 1).FirstOrDefault();
            //if (result is not null)
            //{
            //    Console.WriteLine($"Id = {result.id} \n Name = {result.Name}");

            //}

            #endregion
            #region Update 
            //var result = dBcontext.Employees.FirstOrDefault(E => E.id == 1);
            //if (result is not null)
            //{
            //    result.Name = "Mena";
            //    Console.WriteLine($"Id = {result.id} \n Name = {result.Name}");

            //}
            //dBcontext.SaveChanges();
            #endregion

            #region Remove Data From Table - Delete

            //// هجيب الموظف اللي الـ Id بتاعه = 3
            //var emp01 = dBcontext.Employees.FirstOrDefault(E => E.id == 3);

            //if (emp01 != null)
            //{
            //    // في طريقتين ينفع تستخدم أي واحدة فيهم
            //    // dbContext.Employees.Remove(emp01);
            //    dBcontext.Remove(emp01);

            //    // الحالة هتكون Deleted
            //    Console.WriteLine(dBcontext.Entry<Employee>(emp01).State);

            //    // هيطبق التغيير على قاعدة البيانات
            //    dBcontext.SaveChanges();
            //}

            #endregion

            #endregion

            #region Realationships Between Classes one to one [Total - total]



            #endregion

            #endregion

            #region Session 03 
            #region Data Seed 
            // If you want enter data in Database you have 3 ways
            /*
             * 1- Manual Data Seeding
             * 2-Migration Data Seedin
             * 3-Dynamic Data Seeding 
             */

            #region Manual Data Seeding 
            //Department Dept01 = new Department()
            //{
            //    DeptName = "HR"
            //};

            //dBcontext.Add(Dept01);
            //dBcontext.SaveChanges();


            //List<Department> departments = new List<Department>()
            //{
            //    new Department () {DeptName="IT"},
            //    new Department () {DeptName="Cs"},
            //    new Department () {DeptName="DEv"},
            //    new Department () {DeptName="SEc"},
            //};
            //dBcontext.AddRange(departments);
            //dBcontext.SaveChanges();


            #endregion

            #region Migration Data Seeding
            //use On Model Creating at DbContext Class 
            //Not Commen
            //Insert Data and Add Migration 

            #endregion
            #region Dynamic Data Seeding 
            bool Flag = CompanyDbcontextSeed.Seed(dBcontext);
            if (Flag)
                Console.WriteLine("Data Seed Done ");
            else
                Console.WriteLine( "Falied");
            #endregion
            #endregion
            #endregion
        }
    }
}
