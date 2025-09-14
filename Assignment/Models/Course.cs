using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        //Mapping By convention
        public int Id { get; set; }
        public double Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        

        //RelationShips
        public ICollection<Stud_Course> stud_Courses { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
        [ForeignKey (nameof(Topic))]
        public int? TopicID { get; set; } //FK
        public Topic Topic { get; set; } // Navigation Prop

    }
}
