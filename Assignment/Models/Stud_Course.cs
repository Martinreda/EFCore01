using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }

        [ForeignKey(nameof(Stud_Id))]
        public Student Student { get; set; }

        [ForeignKey(nameof(Course_Id))]
        public Course Course { get; set; }
    }
}
