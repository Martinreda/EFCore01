using Demo.Context;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

           using CompanyDBcontext dBcontext = new CompanyDBcontext();

            // لتطبيق الـ Migrations
            // لازم تنزل الباكدج دي:
            // Microsoft.EntityFrameworkCore.Tools


            //to applAy database in sql server
            // update daatabase

            #endregion

        }
    }
}
