using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public interface IStudentService : IDisposable
    {
        void AddStudent(Student student);
        (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
        void EditStudent(Student student);
        Student LoadStudent(int id);
        Student DeleteStudent(int id);
    }
}
