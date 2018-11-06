using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Services
{
    interface ICourseService

    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourse(int id);

        void CreateCourse(Course course);

        void UpdateCourse(Course course);

        void DeleteCourse(Course course);
    }
}
