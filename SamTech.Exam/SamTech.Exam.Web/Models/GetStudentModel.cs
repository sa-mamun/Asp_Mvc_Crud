using Autofac;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class GetStudentModel : MainBaseModel
    {
        protected IStudentService _studentService;

        public GetStudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        internal object GetStudents(DataTablesAjaxRequestModel tableModel)
        {
            var data = _studentService.GetStudents(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "Username", "Email" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Username,
                                record.Email,
                                record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        public string DeleteStudent(int id)
        {
            var student = _studentService.DeleteStudent(id);
            return student.Name;
        }
    }
}
