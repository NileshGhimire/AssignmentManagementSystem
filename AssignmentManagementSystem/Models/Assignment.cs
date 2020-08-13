using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AssignmentManagementSystem.Models
{
    public class Assignment
    {
        public enum Assignment_grades
        {
            Merit, Pass, Distinction, Fail
        }
        [Key]
        public int Assignment_ID { get; set; }
        public int Student_ID { get; set; }
        public int Teacher_ID { get; set; }
        public int Subject_ID { get; set; }
        public string Assignment_status { get; set; }
        public Assignment_grades? Assignment_grade { get; set; }
    }


}