using Demo.Context;
using Demo.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
[assembly : InternalsVisibleTo ("DynamicProxyGenAssembly2")]

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDBcontext dBcontext = new CompanyDBcontext();

            #region Session 01
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
            //bool Flag = CompanyDbcontextSeed.Seed(dBcontext);
            //if (Flag)
            //    Console.WriteLine("Data Seed Done ");
            //else
            //    Console.WriteLine( "Falied");
            #endregion
            #endregion
            #region Loading raleted Data
            #region Defualt Nav Property
            //var Emp01 = dBcontext.Employees.FirstOrDefault(E => E.Id == 5);
            //if (Emp01 is not null)
            //    Console.WriteLine($"EmpName : {Emp01.Name}");
            //    Console.WriteLine($"Deptid : {Emp01.DeptId}");
            //    Console.WriteLine($"DeptName : {Emp01.MangedDept?.DeptName}");
            #endregion
            #region Eager Loading
            //var Emp01 = dBcontext.Employees.Include(E=> E.EmployeeDepartment).FirstOrDefault(E => E.Id == 5);
            //if (Emp01 is not null)
            //    Console.WriteLine($"EmpName : {Emp01.Name}");
            //Console.WriteLine($"Deptid : {Emp01.DeptId}");
            //Console.WriteLine($"DeptName : {Emp01.EmployeeDepartment.DeptName}");
            #endregion
            #region Explicit Loading 
            #region EX01 Referance
            //var Emp01 = dBcontext.Employees.FirstOrDefault(E => E.Id == 5);
            //if (Emp01 is not null)
            //    Console.WriteLine($"EmpName : {Emp01.Name}");
            //Console.WriteLine($"Deptid : {Emp01.DeptId}");
            //dBcontext.Entry(Emp01).Reference(E => E.EmployeeDepartment).Load();
            //// Referance Method allow with one Nav prop
            //Console.WriteLine($"DeptName : {Emp01.EmployeeDepartment.DeptName}");

            #endregion
            #region Ex02 Collection
            //var Emp01 = dBcontext.Departments.FirstOrDefault(E => E.DeptId == 3);
            //if (Emp01 is not null)
            //    Console.WriteLine($"EmpName : {Emp01.DeptName}");

            ////Explicit Loading
            //dBcontext.Entry(Emp01).Collection(E => E.employees).Query().Where(E=> E.Age > 25).Load();
            //foreach (var item in Emp01.employees)
            //    Console.WriteLine( item.Name);
            #endregion

            #endregion
            #endregion
            #endregion

            #region Session 04 
            #region Lazy Loading 
            // Download Package EF Core.Proxies
            // Congigure in Dbcontext 
            // All Nav Prop Virtal and all Classes Public

            //var Emp01 = dBcontext.Employees.FirstOrDefault(E => E.Id == 5);
            //if (Emp01 is not null)
            //{
            //    Console.WriteLine($"EmployeeName : {Emp01.Name}");
            //    Console.WriteLine($"DeptId : {Emp01.DeptId}");
            //    Console.WriteLine($"DeptName : {Emp01.EmployeeDepartment.DeptName}");//Realted;
            //}
            #endregion

            #region Inner Join
            // From LinQ and must have all realted Data
            //Get dept that has Employees
            //Inner Join

            //var result = dBcontext.Departments
            //    .Join(dBcontext.Employees
            //    , D => D.DeptId,
            //      E => E.DeparmentId,
            //      (D, E) => new
            //      {
            //          EmpId = E.Id,
            //          EmpName = E.Name,
            //          DeptId = D.DeptId,
            //          DeptNAme = D.DeptName
            //      }); 
            //foreach (var item in result )
            //    Console.WriteLine( item);


            /* Get Department Mangers /*/

            var result = dBcontext.Employees.Join(dBcontext.Departments,
                E => E.Id,
                D => D.MangerId,
                (E, D) => new
                {
                    EmpId = E.Id,
                    EmpName = E.Name,
                    DeptId = D.DeptId,
                    DeptNAme = D.DeptName
                });
            foreach (var item in result)
                Console.WriteLine(item);


            #endregion
            #endregion
        }
    }
}
