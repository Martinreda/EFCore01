using Assignment.Context;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbcontext dbcontext = new ITIDbcontext();

            //Change Tracker
            //dbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll; // Defualt 

            #region Student Table 

            //Student student01 = new Student()
            //{
            //    FName = "Martin",
            //    LName = "reda",
            //    Address = "Maghagha",
            //    Age = 26
            //};

            //Console.WriteLine(dbcontext.Entry(student01).State);

            ////Add to database 

            //dbcontext.students.Add(student01);

            //Console.WriteLine(dbcontext.Entry(student01).State);

            //// add realy to database use save changes 
            //dbcontext.SaveChanges();
            #endregion

            #region Read Using LinkQ 
            //var student = dbcontext.students.FirstOrDefault(E => E.Id == 1);
            //if (student is not null)
            //{
            //    Console.WriteLine(dbcontext.Entry(student).State);
            //    Console.WriteLine($"{student.FName}");
            //}
            #endregion

            //02 Add Migrition
            //01Add-Migration InitialCreate -context "ITIDbcontext" 
            // Create Classes (Tables) 
            // Appliy Configrautions 

            #region Manual Data_Seeding 


            List<Student> students = new List<Student>()
            {
                new Student () {FName="Martin", LName = "reda" , Address = "Maghagha", Age = 26 },
                new Student () {FName="Pola", LName = "hani" , Address = "minya", Age = 19},
                new Student () {FName="Mena", LName = "bassem" , Address = "giza", Age = 24},
                new Student () {FName="OKie", LName = "pola" , Address = "cairo", Age = 27},
            };
            dbcontext.AddRange(students);
            dbcontext.SaveChanges();
            #endregion
        }
    }
}
