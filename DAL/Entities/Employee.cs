using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {

        public int Id { get; set; }
        //[Required(ErrorMessage = "Required")]
        //[Range(4000, 8000, ErrorMessage = "Must be Between 40000 and 8000")]
        [DataType(DataType.Currency)]
        public decimal? Salary { get; set; }
        //[MaxLength(50, ErrorMessage = "max Length Must Be less or equal 50")]
        //[MinLength(5, ErrorMessage = "Min Length must or more 5")]
        public string Name { get; set; }

        public string Location { get; set; }

        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int DepartmentId {get;set;} //FK 
        public Department Department { get; set; } 
        public string ImgName { get; set; }
    }
}
