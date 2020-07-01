using Autofac;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class AddSubjectModel : MainBaseModel, IDisposable
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
        public bool RegistrationOpen { get; set; }

        protected ISubjectService _subjectService;

        public AddSubjectModel()
        {
            _subjectService = Startup.AutofacContainer.Resolve<ISubjectService>();
        }

        public void AddSubject()
        {
            var subject = new Subject
            {
                Name = this.Name,
                RegistrationOpen = this.RegistrationOpen
            };

            _subjectService.AddSubject(subject);
        }

        public void Dispose()
        {
            _subjectService?.Dispose();
        }
    }
}
