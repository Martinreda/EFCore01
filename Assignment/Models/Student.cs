using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student

    {
        //Mapping By convention
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
       
        //relation 
        //Relations 
        [ForeignKey(nameof(Department))]
        public int? DepartmentId { get; set; } // FK
        public Department Department { get; set; }

        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
