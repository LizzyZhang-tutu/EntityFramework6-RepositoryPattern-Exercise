using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(SchoolContext context)
            : base(context)
        {

        }

        public SchoolContext SchoolContext
        {
            get { return Context as SchoolContext; }
        }


    }
}