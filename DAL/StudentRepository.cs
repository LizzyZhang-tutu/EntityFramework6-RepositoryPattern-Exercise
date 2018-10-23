using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolContext context)
            : base(context)
        {

        }

        public SchoolContext SchoolContext
        {
            get { return Context as SchoolContext;  }
        }

     
    }
}