using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required]
        [Column(TypeName ="varchar (50)")]
        public string? DeptName { get; set; }

        //Nav prop
        //    public Employee? Manger { get; set; } // ? Partial RElationship
        [InverseProperty(nameof(Employee.MangedDept))]
        public Employee Manger { get; set; } // Naav Prop 
        //FK Here
        public int MangerId { get; set; }

        //One to many 
        [InverseProperty(nameof(Employee.department))] // دي بتخلي تفهم انها تقصد العلاقه دي 
        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();


    }
}
