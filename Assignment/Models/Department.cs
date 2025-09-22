using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department

    {
        //Mapping By convention
        public int Id { get; set; }
        
        public string? Name { get; set; }
        public string? HiringDate { get; set; }

        //relation 
        public ICollection<Student> students { get; set; } = new HashSet<Student>();

        [ForeignKey (nameof(manger))]
        public int? mangerId { get; set; }
        public Instructor manger { get; set; }


        [InverseProperty (nameof (Instructor.WorkForDept))]
        public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();

    } 
}
