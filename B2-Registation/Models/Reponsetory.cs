using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public static class Reponsetory
    {
        private static List<Student> _student = new List<Student>();
        public static List<Student> GetStudents()
        {
            return _student;
        }
        public static void AddStudent(Student student)
        {
            _student.Add(student);
        }
    }
}
