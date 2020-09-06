using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace projectnetwork.Models
{
    public class Admin
    {
        [Required(ErrorMessage = "Required filed !")]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "Invalid id")]
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Required filed !")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Required filed !")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Invalid last name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Required filed !")]
        [RegularExpression("^[a-zA-Z]+[0-9][0-9]$", ErrorMessage = "User name must contain name and 2 digit")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required filed !")]
        [RegularExpression("^[A-Z]{1}[a-z]{1}[a-zA-Z0-9]{6}$", ErrorMessage = "Password must contain 1 uppercase , 1 lowercase and digits")]
        public string Password { get; set; }


        public string Permmision { get; set; }


    }
}