using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class StudentService : IStudentService
    {
        private readonly IStudentUnitOfWork _studentUnitOfWork;

        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }
        
        public void AddStudent(Student student)
        {
            var count = _studentUnitOfWork.StudentRepository.GetCount(x => x.Name == student.Name);
            if(count > 0)
            {
                throw new DuplicationException("Student already exists", nameof(student.Name));
            }
            
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save();
        }

        public Student DeleteStudent(int id)
        {
            var student = _studentUnitOfWork.StudentRepository.GetById(id);
            _studentUnitOfWork.StudentRepository.Remove(student);
            _studentUnitOfWork.Save();
            return student;
        }

        public void Dispose()
        {
            _studentUnitOfWork?.Dispose();
        }

        public void EditStudent(Student student)
        {
            var count = _studentUnitOfWork.StudentRepository.GetCount(x => x.Name == student.Name && x.Id != student.Id);
            if(count > 0)
            {
                throw new DuplicationException("Student already exists", nameof(student.Name));
            }

            var existingStudent = _studentUnitOfWork.StudentRepository.GetById(student.Id);
            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;
            existingStudent.Username = student.Username;

            _studentUnitOfWork.Save();
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _studentUnitOfWork.StudentRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        public Student LoadStudent(int id)
        {
            return _studentUnitOfWork.StudentRepository.GetById(id);
        }
    }
}
