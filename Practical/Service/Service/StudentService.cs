using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class StudentService
    {
        private Student[] GetAll()
        {
            return new Student[]
            {
                new Student{Id = 1, FullName = "Person Surname 1", Age = 20, Email = "personsurname1@gmail.com"},
                new Student{Id = 2, FullName = "Person Surname 2", Age = 15, Email = "personsurname2@gmail.com"},
                new Student{Id = 3, FullName = "Person Surname 3", Age = 24, Email = "personsurname3@gmail.com"}
            };
        }

        public Student[] GetAllStudents() 
        {
            return GetAll();
        }

        public Student GetById(int id)
        {
            return GetAll().FirstOrDefault(m => m.Id == id);
        }
    }
}
