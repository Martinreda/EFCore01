using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Context
{
    public class CompanyDbcontextSeed
    {
        public static bool Seed(CompanyDBcontext dBcontext)
        {
            try
            {
                //Table Employee  
                if (!dBcontext.Employees.Any())
                {
                    var EmpsData = File.ReadAllText("Files\\employees.json");
                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmpsData);
                    //Add Employess
                    if (Employees.Count > 0)
                    {
                        dBcontext.AddRange(Employees); //Added
                        dBcontext.SaveChanges();

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
