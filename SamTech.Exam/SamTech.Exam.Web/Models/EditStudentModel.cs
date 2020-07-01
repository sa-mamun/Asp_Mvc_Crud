using Autofac;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class EditStudentModel : MainBaseModel
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        protected IStudentService _studentService;

        public EditStudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public void EditStudent()
        {
            var student = new Student
            {
                Id = this.Id,
                Name = this.Name,
                Username = this.Username,
                Email = this.Email
            };

            _studentService.EditStudent(student);
        }

        public void LoadData(int id)
        {
            var oldStudentData = _studentService.LoadStudent(id);
            if(oldStudentData != null)
            {
                Id = oldStudentData.Id;
                Name = oldStudentData.Name;
                Username = oldStudentData.Username;
                Email = oldStudentData.Email;
            }
        }
    }
}
