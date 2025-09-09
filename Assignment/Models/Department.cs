using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {
        //Mapping By convention
        public int Id { get; set; }
        
        public string Name { get; set; }
        public int inst_Id { get; set; }
        public string HiringDate { get; set; }
    }
}
