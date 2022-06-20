using LabBigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabBigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public bool ShowAction { get; set; }
        public IQueryable<Course> UpcommingCourses { get; set; }
    }
}