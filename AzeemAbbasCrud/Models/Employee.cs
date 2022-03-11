using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzeemAbbasCrud.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Display(Name ="Employee Name")]
        [Required(ErrorMessage ="Employee Name can't Empty !")]
        [MinLength(3,ErrorMessage ="Name Must be min 3 char !")]
        [MaxLength(30, ErrorMessage = "Name Must be max 30 char !")]
        public string Name { get; set; }

        [Display(Name = "Employee Email Address")]
        [Required(ErrorMessage = "Employee Email can't Empty !")]
        [EmailAddress(ErrorMessage ="Email Address is not valid !")]
        public string Email { get; set; }

        [Display(Name = "Employee Mobile")]
        [Required(ErrorMessage = "Employee Mobile Number can't Empty !")]
        public string Mobile { get; set; }

        [Display(Name = "Employee Address")]
        [Required(ErrorMessage = "The Employee Address field Required !")]
        [MinLength(5, ErrorMessage = "Name Must be min 5 char !")]
        [MaxLength(30, ErrorMessage = "Name Must be max 30 char !")]
        public string Address { get; set; }
    }
}
