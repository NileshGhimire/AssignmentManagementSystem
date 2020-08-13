using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AssignmentManagementSystem.Models
{
    public class Faculty
    {
        [Key]
        public int Faculty_ID { get; set; }
        public string Faculty_name { get; set; }
        public int Faculty_year { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }

    }

    }