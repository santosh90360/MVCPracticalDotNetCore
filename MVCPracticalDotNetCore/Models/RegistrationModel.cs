using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCPracticalDotNetCore.Models
{
    public class RegistrationModel
    {
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }

    }
}
