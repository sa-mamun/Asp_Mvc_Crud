﻿using Autofac;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class AddStudentModel : MainBaseModel, IDisposable
    {
        public int Id { get; set; }
        
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        protected IStudentService _studentService;

        public AddStudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        public void AddStudent()
        {
            var student = new Student
            {
                Name = this.Name,
                Username = this.Username,
                Email = this.Email
            };

            _studentService.AddStudent(student);
        }

        public void Dispose()
        {
            _studentService?.Dispose();
        }
    }
}
