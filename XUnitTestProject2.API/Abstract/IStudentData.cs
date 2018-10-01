using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XUnitTestProject2.API.Models;

namespace XUnitTestProject2.API.Abstract
{
    public interface IStudentData
    {
        List<Student> getAllStudent();
    }
}
