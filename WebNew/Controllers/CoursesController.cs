using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNew.Models;
using WebNew.ViewModels;

namespace WebNew.Controllers
{
    public class CoursesController : Controller
    {
        public readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new Models.ApplicationDbContext();
        }

        public List<Category> Categories { get; private set; }
        

        // GET: Courses

        [Authorize]
            [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            
            var course = new Course
            {
                LecturerID = User.Identity.GetUserId(),
                DataTime = viewModel.GetDateTime(),
                CategoryId = ViewModels.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}