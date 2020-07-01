using Autofac;
using Microsoft.AspNetCore.Http;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class MainBaseModel
    {     
        public MenuModel Menu { get; set; }
        public ResponseModel Response
        {
            get
            {
                if(_httpContextAccessor.HttpContext.Session.IsAvailable &&
                    _httpContextAccessor.HttpContext.Session.Keys.Contains(nameof(Response)))
                {
                    var response = _httpContextAccessor.HttpContext.Session.Get<ResponseModel>(nameof(Response));
                    _httpContextAccessor.HttpContext.Session.Remove(nameof(Response));
                    return response;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.Set(nameof(Response), value);
            }
        }


        public IHttpContextAccessor _httpContextAccessor;
        public MainBaseModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            SetMenu();
        }

        public MainBaseModel()
        {
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
            SetMenu();
        }

        private void SetMenu()
        {
            Menu = new MenuModel
            {
                MenuItems = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Title = "Student",
                        Childs = new List<MenuChildItem>
                        {
                            new MenuChildItem
                            {
                                Title = "Add Students",
                                Url = "/Home/AddStudent"
                            },
                            new MenuChildItem
                            {
                                Title = "View Students",
                                Url = "/Home/Index"
                            }
                        }
                    },
                    new MenuItem
                    {
                        Title = "Subject",
                        Childs = new List<MenuChildItem>
                        {
                            new MenuChildItem
                            {
                                Title = "Add Subjects",
                                Url = "/Home/AddSubject"
                            },
                            new MenuChildItem
                            {
                                Title = "View Subjects",
                                Url = "/Home/GetSubject"
                            }
                        }
                    }
                }
            };
        }
    }
}
