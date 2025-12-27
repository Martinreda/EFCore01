using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    [Table ("usersTable")]
    public class User
    {
        [Key]
        public int SSN { get; set; } // SSn PK with constrain (1,1)
        [Required]
        [Column("UserName", TypeName = "Varchar(50)")]
        [MaxLength(50, ErrorMessage = "name must be less 51 ")]
        [MinLength(3, ErrorMessage = "name must be less 3 ")]

        public string UName { get; set; }
        [Required]
        [Range (20,50)]
        public int Age { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
