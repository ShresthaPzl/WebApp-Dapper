using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Employee
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Country is required!")]
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public int Department_Id { get; set; }

        public string StatusMessage { get; set; }
    }
}
