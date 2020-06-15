using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNew.Models
{
    public class Course
    {
        public int Id { get ; set;}
        public bool IsCanceled { get; set; }
        public ApplicationUser Lecturer { get; set; }
        public String LecturerId { get; set; }
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Category Category { get; set; }
        public byte CategoryId { get; set; }
        //public object LecturerID { get; internal set; }
        //public object DataTime { get; internal set; }
        //public class Category
        //{
        //    public byte Id { get; set; }
        //    [Required]
        //    [StringLength(255)]
        //    public string Name { get; set; }

        //}
    
    }
    
}