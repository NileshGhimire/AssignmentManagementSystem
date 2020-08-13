using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AssignmentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int Student_ID { get; set; }
        public string Student_name { get; set; }
        public string Student_contact { get; set; }
        public string Faculty_ID { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }


    }
