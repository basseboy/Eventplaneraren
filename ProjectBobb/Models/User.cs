using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectBobb.Models
{
    public class User
    {
        [Key, MaxLength(40), Required]
        public string Email { get; set; }
        [MaxLength(20), Required]
        public string Password { get; set; }
        [MaxLength(20), Required]
        public string Firstname { get; set; }
        [MaxLength(25), Required]
        public string Lastname { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        public string Picture { get; set; }
    }
}