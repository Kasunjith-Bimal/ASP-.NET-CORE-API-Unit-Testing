using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XUnitTestProject2.API.Abstract;
using XUnitTestProject2.API.Models;

namespace XUnitTestProject2.API.Confreate
{
    public class StudentData : IStudentData
    {
        public StudentDbContext _db;
        public StudentData(StudentDbContext db)
        {
            _db = db;
        }
        public List<Student> getAllStudent()
        {
            return _db.Students.ToList();
        }
    }
}
