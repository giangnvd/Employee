﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Annotation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage ="Employee Name is required")]
        [StringLength(35, MinimumLength =6)]
        public string   Name { get; set; }

        [Required(ErrorMessage = "Employee Address is required")]
        [StringLength(300)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary  is required")]
        [Range(3000, 1000000,ErrorMessage ="Salary must bet betwen 300 and 1000000")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage ="Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [DisplayName ( "Email Address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",ErrorMessage ="Please enter correct email adderss.")]
        public string Email{ get; set; }
    }
}   