using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssignmentManagementSystem.Models
{
    public class Teacher
    {
        [Key]
        public int Teacher_ID { get; set; }
        public string Teacher_name { get; set; }
        public string Teacher_contact { get; set; }
        public string Teacher_address { get; set; }
        public int Faculty_ID { get; set; }

    }

}