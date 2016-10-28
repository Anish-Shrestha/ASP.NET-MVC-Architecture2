using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirstEntities;

namespace CodeFirstServices.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        void SaveStudent();
    }
}
