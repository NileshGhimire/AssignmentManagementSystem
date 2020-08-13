using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AssignmentManagementSystem.Models
{
    public class Subject
    {
        [Key]
        public int Subject_ID { get; set; }
        public string Subject_name { get; set; }
        public string Faculty_ID { get; set; }
        public string Teacher_ID { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}