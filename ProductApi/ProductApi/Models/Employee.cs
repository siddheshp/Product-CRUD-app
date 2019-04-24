using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Department { get; set; }
    }
}