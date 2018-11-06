using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;
using ContosoUniversity.DAL;
using System.Data.Entity;

namespace ContosoUniversity.Services
{
    public class CourseService : ICourseService, IDisposable
    {
        private readonly SchoolContext _schoolContext;

        //Dependency Injection: Inject context in service
        public CourseService()
        {
            _schoolContext = new SchoolContext();
        }


        public void CreateCourse(Course course)
        {
            _schoolContext.Courses.Add(course);
            _schoolContext.SaveChanges();
        }

        public void DeleteCourse(Course course)
        {
            _schoolContext.Courses.Remove(course);
            _schoolContext.SaveChanges();
        }

        public void Dispose()
        {
            _schoolContext?.Dispose();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _schoolContext.Courses.AsEnumerable();
        }

        public Course GetCourse(int id)
        {
            return _schoolContext.Courses.SingleOrDefault(c => c.CourseID == id);
        }

        public void UpdateCourse(Course course)
        {
            _schoolContext.Entry(course).State = EntityState.Modified;
            _schoolContext.SaveChanges();
        }
    }
}