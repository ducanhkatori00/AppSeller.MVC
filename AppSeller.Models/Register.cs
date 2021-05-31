using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppSeller.Models
{
    public class Register
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType()]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
