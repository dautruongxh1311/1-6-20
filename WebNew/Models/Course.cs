using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebNew.Models
{
    public class Course
    {
        public int Id { get ; set;}
        public ApplicationUser Lecturer { get; set; }
        public String LecturerId { get; set; }
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Category CategoryId { get; set; }
              
       
    }
    
}