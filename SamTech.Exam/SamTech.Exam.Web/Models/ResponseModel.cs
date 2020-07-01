using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class ResponseModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string IconCssClass { get; set; }
        public string StyleCssClass { get; set; }

        public ResponseModel()
        {

        }

        public ResponseModel(string message, ResponseType type)
        {
            if(type == ResponseType.Success)
            {
                Title = "Success";
                IconCssClass = "alert-success";
                StyleCssClass = "fa-check";
            }
            else if(type == ResponseType.Failure)
            {
                Title = "Error";
                IconCssClass = "alert-danger";
                StyleCssClass = "fa-ban";
            }

            Message = message;

        }
    }
}
