using InheirtanceMapping.Context;
using InheirtanceMapping.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace InheirtanceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyRouteG02DbContext dBContext = new CompanyRouteG02DbContext();
            #region 1- Table Per Concrete Type TPCT

            //FullTimeEmployee ftEmp = new FullTimeEmployee()
            //{
            //    Name = "Martin",
            //    Age = 26,
            //    Salary = 47000, 
            //    Address = "Cairo"
            //};

            //PartTimeEmployee ptEmp = new PartTimeEmployee()
            //{
            //    Name = "reda",
            //    Age = 51,
            //    HourRate = 50,
            //    Address = "Viena",
            //    CountOfHours = 150
            //};
            //dBContext.Add(ftEmp);
            //dBContext.Add(ptEmp);
            //dBContext.SaveChanges();

            //var PTE = dBContext.partTimeEmployees.FirstOrDefault();
            //Console.WriteLine(PTE.CountOfHours);

            #endregion
        }
    }
}
