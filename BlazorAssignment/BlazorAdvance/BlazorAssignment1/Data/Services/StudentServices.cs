using BlazorAssignment1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment1.Data.Services
{
    public class StudentServices
    {
        private readonly BlazorDbContext _db;

        public StudentServices(BlazorDbContext db)
        {
            _db = db;
        }

        public List<StudentInfo> GetStudent()
        {
            var studentList = _db.Students.ToList();
            return studentList;
        }

        public string InsertData(StudentInfo student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return "Successfully";

        }
        public StudentInfo GetStudentById(int id)
        {
            StudentInfo student = _db.Students.FirstOrDefault(s => s.StudentId == id);
            return student;
        }

        public string UpdateStudent(StudentInfo student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
            return "Update successfully";
        }

        public string DeleteStudent(StudentInfo student)
        {
            _db.Students.Remove(student);
            _db.SaveChanges();
            return "Deleted successfully";
        }
    }
}
