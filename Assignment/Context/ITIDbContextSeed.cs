using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class ITIDbContextSeed
    {
        public static bool Seed(ITIDbcontext dbcontext)
        {
            try
            {
                //Table Department  
                if (!dbcontext.instructors.Any())
                {
                    var DeptData = File.ReadAllText("Files\\instructors.json");
                    var Dept = JsonSerializer.Deserialize<List<Instructor>>(DeptData);
                    //Add Employess
                    if (Dept != null && Dept.Count > 0)
                    {
                        dbcontext.AddRange(Dept); //Added
                        dbcontext.SaveChanges();

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
