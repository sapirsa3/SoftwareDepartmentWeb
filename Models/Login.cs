using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projectnetwork.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Required filed !")]
        [RegularExpression("^[a-zA-Z]+[0-9]+$", ErrorMessage = "Invalid username")]
        [Key]
        public string Username { get; set; }
        [Required(ErrorMessage ="Required filed !")]
        [RegularExpression("^[A-Z]{1}[a-z]{1}[a-zA-Z0-9]{6}$", ErrorMessage = "Password must contain 1 uppercase , 1 lowercase and digits")]
        public string Password { get; set; }

        public string Permmision { get; set; }


    }

}
