using Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class StudentService
    {
        private Student[] GetAll()
        {
            return new Student[]
            {
                new Student { Id = 1, FullName = "Person A", Age = 30, Email = "persona@gmail.com" },
                new Student { Id = 2, FullName = "Person B", Age = 20, Email = "personb@gmail.com" },
                new Student { Id = 3, FullName = "Person C", Age = 10, Email = "personc@gmail.com" }
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

        public Student SortByAge()
        {
            return GetAll().OrderByDescending(m => m.Age).FirstOrDefault();
        }

        //public Student StudentAgeAverage()
        //{
        //    //return GetAll().Average(m => m.Age); ==== Bunu bilmirem neter duzeldim
        //}
    }
}
