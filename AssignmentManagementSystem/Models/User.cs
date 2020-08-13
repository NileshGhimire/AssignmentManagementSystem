using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace AssignmentManagementSystem.Models
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Userid { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="FirstName is required")]
        public string FirstName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email Adress is required")]
        public string Email{ get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
        public string UserName{ get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please enter the Password")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password And Confirm Password Does Not Match")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string ConfrimPassword { get; set; }
        



    }
}