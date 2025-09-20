using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Nav Many
        public virtual ICollection<Student> Students { get; set; }
    }
}
