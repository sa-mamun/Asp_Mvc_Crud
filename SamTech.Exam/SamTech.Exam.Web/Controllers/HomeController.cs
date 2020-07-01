using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SamTech.Exam.Framework;
using SamTech.Exam.Web.Models;

namespace SamTech.Exam.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new AddStudentModel();
            return View(model);
        }

        public IActionResult AddStudent()
        {
            var model = new AddStudentModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(
            [Bind(nameof(AddStudentModel.Name), nameof(AddStudentModel.Username), nameof(AddStudentModel.Email))]
                AddStudentModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    model.AddStudent();
                    model.Response = new ResponseModel("Student Added Successfully", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch(DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                }
                catch(Exception ex)
                {
                    model.Response = new ResponseModel("Failed to Add Student", ResponseType.Failure);
                }
            }
            return View(model);
        }

        public IActionResult EditStudent(int id)
        {
            var model = new EditStudentModel();
            model.LoadData(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditStudent(
            [Bind(  nameof(EditStudentModel.Id),
                    nameof(EditStudentModel.Name),
                    nameof(EditStudentModel.Username),
                    nameof(EditStudentModel.Email))] EditStudentModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.EditStudent();
                    model.Response = new ResponseModel("Student Added Successfully", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Failed to Add Student", ResponseType.Failure);
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudent(int id)
        {
            var model = new GetStudentModel();
            if (ModelState.IsValid)
            {
                try
                {
                    var Name = model.DeleteStudent(id);
                    model.Response = new ResponseModel($"Student '{Name}' Successfully Deleted", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Failed to Delete Student", ResponseType.Failure);
                }
            }
            return View(model);
        }

        public IActionResult AddSubject()
        {
            var model = Startup.AutofacContainer.Resolve<AddSubjectModel>();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSubject(
            [Bind(nameof(AddSubjectModel.Name), nameof(AddSubjectModel.RegistrationOpen))] AddSubjectModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    model.AddSubject();
                    ViewBag.ResponseMessage = "Successfuly Added Subject";
                }
                catch(Exception ex)
                {
                    ViewBag.ResponseMessage = "Failed to Add Subject";
                }
            }

            return View();
        }

        public IActionResult GetSubject()
        {
            var model = new AddSubjectModel();
            return View(model);
        }

        public IActionResult ShowSubjects()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<GetSubjectModel>();
            var data = model.GetSubjects(tableModel);
            return Json(data);
        }

        public IActionResult AddGrade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGrade(AddGradeModel model)
        {
            model.AddGrade();
            return RedirectToAction("AddGrade");
        }

        public IActionResult GetStudents()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<GetStudentModel>();
            var data = model.GetStudents(tableModel);
            return Json(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
