using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Services
{
    interface IStudentService

    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);

        void CreateStudent(Student student);

        void UpdateStudent(Student student);

        void DeleteStudent(Student student);
    }
}
