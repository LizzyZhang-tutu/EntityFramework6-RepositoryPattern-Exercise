using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;
using ContosoUniversity.DAL;
using System.Data.Entity;

namespace ContosoUniversity.Services
{
    public class StudentService : IStudentService, IDisposable
    {

        private readonly SchoolContext _schoolContext;

        //Dependency Injection: Inject context in service
        public StudentService()
        {
            _schoolContext = new SchoolContext();
        }

        public void CreateStudent(Student student)
        {
            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {
            _schoolContext.Students.Remove(student);
            _schoolContext.SaveChanges();
        }

        public void Dispose()
        {
            _schoolContext?.Dispose();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _schoolContext.Students.AsEnumerable();
        }

        public Student GetStudent(int id)
        {
            return _schoolContext.Students.SingleOrDefault(c => c.ID == id);
        }

        public void UpdateStudent(Student student)
        {
            _schoolContext.Entry(student).State = EntityState.Modified;
            _schoolContext.SaveChanges();
        }
    }
}