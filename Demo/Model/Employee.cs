using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    //Model == enttity == domain entity :poco class
    internal class Employee
    {
        public int id { get; set; }
        
        public string? Name { get; set; }
        
        public decimal salary { get; set; }
        public int Age { get; set; }
    }
}
