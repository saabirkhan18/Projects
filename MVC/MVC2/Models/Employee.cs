using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MVC2.Models
{
    public class Employee
    {
        [Required]
        public string Name { set; get; }

        [Required]
        public string Gender { set; get; }

        [Required]
        public string Country { set; get; }

        [Required]
        public string PhoneNumber { set; get; }
        //public string Country { set; get; }
    }
}
