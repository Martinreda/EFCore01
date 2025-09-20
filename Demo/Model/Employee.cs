using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    //Model == enttity == domain entity :poco class
    public class Employee
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public decimal Salary { get; set; }
        public int Age { get; set; }

        //Navigational  Prop 
        //Represnt relationship of 1   to    1
        //EfF Core By Convention => Department has one Employee To Manage it 

        //public Department DeptManger { get; set; } //Navigational  Prop 

        ////FK 
        //[ForeignKey (nameof (DeptManger))]
        //public int MangerDeptId { get; set; }

        [InverseProperty(nameof(Department.Manger))]
        public virtual Department MangedDept { get; set; } // Naav Prop 

        //one to one t -- t
        public Address EmpAddress { get; set; }

        // One to many 

        //FK 
        [ForeignKey(nameof(DeptId))]
        public int DeptId { get; set; }

         
        [InverseProperty(nameof(Department.employees))] // Inverse Prop
        public virtual Department EmployeeDepartment { get; set; }  // Nav prop


    }
}
