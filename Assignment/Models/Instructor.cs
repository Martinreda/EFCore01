using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bounce { get; set; }
        public double salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }

        [InverseProperty(nameof(Department.manger))]
        public Department MangeDepartment { get; set; }


        [ForeignKey(nameof(WorkForDept))]
        public int? DepartmentId { get; set; }

        [InverseProperty(nameof(Department.instructors))]
        public Department WorkForDept { get; set; } //Nav prop

        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
