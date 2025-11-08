using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course_Inst
    {
        //Mapping By convention
        [Key]
        public int inst_Id { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }
 
    }
}
