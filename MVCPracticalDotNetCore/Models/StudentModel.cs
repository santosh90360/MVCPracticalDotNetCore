using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPracticalDotNetCore.Models
{
    public class StudentModel
    {
        [Display(Name="Role Number")]
        public int RoleNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public decimal Math { get; set; }
        public decimal English { get; set; }
        public decimal Science { get; set; }
        public decimal Hindi { get; set; }
        [Display(Name = "Social Science")]
        public decimal SocialScience { get; set; }
        public decimal TotalMark { get; set; }
    }
}
