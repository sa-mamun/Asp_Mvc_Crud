using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class SubjectService : ISubjectService
    {
        private readonly IStudentUnitOfWork _studentUnitOfWork;

        public SubjectService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void AddSubject(Subject subject)
        {
            var count = _studentUnitOfWork.SubjectRepository.GetCount(x => x.Name == subject.Name);
            if(count > 0)
            {
                throw new DuplicationException("Subject Name Alrady Exists", nameof(subject.Name));
            }
            _studentUnitOfWork.SubjectRepository.Add(subject);
            _studentUnitOfWork.Save();
        }

        public void Dispose()
        {
            _studentUnitOfWork?.Dispose();
        }

        public (IList<Subject> records, int total, int totalDisplay) GetSubjects(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _studentUnitOfWork.SubjectRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
