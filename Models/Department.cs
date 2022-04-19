using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Department
    {
        [Display(Name = "Department Id")]
        public int Department_Id { get; set; }
        [Required(ErrorMessage = "Department is required!")]
        public String Department_Name { get; set; }

    }
}
