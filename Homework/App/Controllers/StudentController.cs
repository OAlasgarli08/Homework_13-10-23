using Domain.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class StudentController
    {
        private readonly StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            foreach (var student in students)
            {
                string result = $"{student.FullName} + {student.Age} + {student.Email}";
                Console.WriteLine(result);
            }

        }

        public void GetById()
        {
            var students = _studentService.GetById(2);
            string result = $"{students.FullName} + {students.Age} + {students.Email}";
            Console.WriteLine(result);
        }
        public void SortByAge()
        {
            var students = _studentService.GetAllStudents();
            foreach (var student in students)
            {
                string result = $"{student.FullName} + {student.Age} + {student.Email}";
                Console.WriteLine(result);
            }
        }
    }
}
