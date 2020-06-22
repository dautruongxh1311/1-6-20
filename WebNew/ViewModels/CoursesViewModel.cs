using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNew.Models;

namespace WebNew.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public IEnumerable<ApplicationUser> Follows { get; set; }
    }
}