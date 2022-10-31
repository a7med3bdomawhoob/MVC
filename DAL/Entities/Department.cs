using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Department
    {
        public int  Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="name is Required")]
        [StringLength(maximumLength:100,MinimumLength =5,ErrorMessage ="name must be more than 5 and less100")]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public virtual ICollection<Department> Departments { get; set; }


    }
}
