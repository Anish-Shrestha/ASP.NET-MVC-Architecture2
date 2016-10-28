using System.Collections.Generic;
using CodeFirstData.DBInteractions;
using CodeFirstData.EntityRepositories;
using CodeFirstEntities;
using CodeFirstServices.Interfaces;

namespace CodeFirstServices.Services
{
    public class StudentService : IStudentService
    {
         private readonly IStudentRepository _studentRepository;
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        {
            this._studentRepository = studentRepository;
            this._unitOfWork = unitOfWork;
        }  
        #region IStudentService Members

        public IEnumerable<Student> GetStudents()
        {
            var students = _studentRepository.GetAll();
            return students;
        }

        public Student GetStudentById(int id)
        {
            var student = _studentRepository.GetById(id);
            return student;
        }

        public void CreateStudent(Student student)
        {
            _studentRepository.Add(student);
            _unitOfWork.Commit();
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.GetById(id);
            _studentRepository.Delete(student);
            _unitOfWork.Commit();
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
            _unitOfWork.Commit();
        }

        public void SaveStudent()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}
