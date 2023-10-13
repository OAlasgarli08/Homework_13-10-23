using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Controllers
{
    internal class StudentController
    {
        private readonly StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }
        public void GetAllStudnets()
        {
            var students = _studentService.GetAllStudents();
            foreach(var item in students)
            {
                string result = $"{item.FullName} - {item.Age} - {item.Email}";

                Console.WriteLine(result);
            }
        }

        public void GetStudentById()
        {
            var student = _studentService.GetById(1);
            string result = $"{student.FullName} - {student.Age} - {student.Email}";
            Console.WriteLine(result);
        }
    }

}
