#pragma checksum "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc2bcff92b49f9ef53e956edf6d677a6d6e86b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LeftMenu), @"mvc.1.0.view", @"/Views/Shared/_LeftMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\_ViewImports.cshtml"
using SamTech.Exam.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\_ViewImports.cshtml"
using SamTech.Exam.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc2bcff92b49f9ef53e956edf6d677a6d6e86b2", @"/Views/Shared/_LeftMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e34eb054948960c59d4321f45062d108009ee59", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LeftMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""mt-2"">
    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
        <!-- Add icons to the links using the .nav-icon class
         with font-awesome or any other icon font library -->

");
#nullable restore
#line 7 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
         foreach (var item in Model.MenuItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item has-treeview menu-open\">\r\n                <a href=\"#\" class=\"nav-link\">\r\n                    <i class=\"nav-icon fas fa-tachometer-alt\"></i>\r\n                    <p>\r\n                        ");
#nullable restore
#line 13 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <i class=\"right fas fa-angle-left\"></i>\r\n                    </p>\r\n                </a>\r\n                <ul class=\"nav nav-treeview\">\r\n");
#nullable restore
#line 18 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
                     foreach (var subitem in item.Childs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=", 893, "", 911, 1);
#nullable restore
#line 21 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
WriteAttributeValue("", 899, subitem.Url, 899, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>");
#nullable restore
#line 23 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
                              Write(subitem.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 26 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </li>\r\n");
#nullable restore
#line 29 "D:\Asp_Net_MVC\SamTech.Exam\SamTech.Exam.Web\Views\Shared\_LeftMenu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-tachometer-alt""></i>
                <p>
                    Dashboard
                    <i class=""right fas fa-angle-left""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../../index.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Dashboard v1</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../../index2.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Dashboard v2</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../../index3.html"" class=""nav-link"">
                        <i class=""far fa-c");
            WriteLiteral(@"ircle nav-icon""></i>
                        <p>Dashboard v3</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a href=""../widgets.html"" class=""nav-link"">
                <i class=""nav-icon fas fa-th""></i>
                <p>
                    Widgets
                    <span class=""right badge badge-danger"">New</span>
                </p>
            </a>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-copy""></i>
                <p>
                    Layout Options
                    <i class=""fas fa-angle-left right""></i>
                    <span class=""badge badge-info right"">6</span>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../layout/top-nav.html"" class=""nav-link"">
                        <i class=""far ");
            WriteLiteral(@"fa-circle nav-icon""></i>
                        <p>Top Navigation</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../layout/top-nav-sidebar.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Top Navigation + Sidebar</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../layout/boxed.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Boxed</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../layout/fixed-sidebar.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Fixed Sidebar</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../layout");
            WriteLiteral(@"/fixed-topnav.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Fixed Navbar</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../layout/fixed-footer.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Fixed Footer</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../layout/collapsed-sidebar.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Collapsed Sidebar</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-chart-pie""></i>
                <p>
                    Charts
                    <i class=""right fas ");
            WriteLiteral(@"fa-angle-left""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../charts/chartjs.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>ChartJS</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../charts/flot.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Flot</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../charts/inline.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Inline</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
               ");
            WriteLiteral(@" <i class=""nav-icon fas fa-tree""></i>
                <p>
                    UI Elements
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../UI/general.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>General</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../UI/icons.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Icons</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../UI/buttons.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Buttons</p>
                    </a>
                </li>
           ");
            WriteLiteral(@"     <li class=""nav-item"">
                    <a href=""../UI/sliders.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Sliders</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../UI/modals.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Modals & Alerts</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../UI/navbar.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Navbar & Tabs</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../UI/timeline.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Timeline</p>
                    </a>
    ");
            WriteLiteral(@"            </li>
                <li class=""nav-item"">
                    <a href=""../UI/ribbons.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Ribbons</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-edit""></i>
                <p>
                    Forms
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../forms/general.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>General Elements</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../forms/advanced.html"" class=""nav-lin");
            WriteLiteral(@"k"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Advanced Elements</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../forms/editors.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Editors</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../forms/validation.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Validation</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item has-treeview menu-open"">
            <a href=""#"" class=""nav-link active"">
                <i class=""nav-icon fas fa-table""></i>
                <p>
                    Tables
                    <i class=""fas fa-angle-left right""></i>
                </p>
            WriteLiteral(@"
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../tables/simple.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Simple Tables</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../tables/data.html"" class=""nav-link active"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>DataTables</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../tables/jsgrid.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>jsGrid</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-header"">EXAMPLES</li>
        <li class=""nav-item"">
            <a href=""../calendar.html"" class=""nav");
            WriteLiteral(@"-link"">
                <i class=""nav-icon far fa-calendar-alt""></i>
                <p>
                    Calendar
                    <span class=""badge badge-info right"">2</span>
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""../gallery.html"" class=""nav-link"">
                <i class=""nav-icon far fa-image""></i>
                <p>
                    Gallery
                </p>
            </a>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon far fa-envelope""></i>
                <p>
                    Mailbox
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../mailbox/mailbox.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                 ");
            WriteLiteral(@"       <p>Inbox</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../mailbox/compose.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Compose</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../mailbox/read-mail.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Read</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-book""></i>
                <p>
                    Pages
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                   ");
            WriteLiteral(@" <a href=""../examples/invoice.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Invoice</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/profile.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Profile</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/e_commerce.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>E-commerce</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/projects.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Projects</p>
                    </a>
                </li>
          ");
            WriteLiteral(@"      <li class=""nav-item"">
                    <a href=""../examples/project_add.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Project Add</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/project_edit.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Project Edit</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/project_detail.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Project Detail</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/contacts.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p");
            WriteLiteral(@">Contacts</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon far fa-plus-square""></i>
                <p>
                    Extras
                    <i class=""fas fa-angle-left right""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""../examples/login.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Login</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/register.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Register</p>
                    </a>
                </li>
                <li class=""nav-item"">
                ");
            WriteLiteral(@"    <a href=""../examples/forgot-password.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Forgot Password</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/recover-password.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Recover Password</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/lockscreen.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Lockscreen</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/legacy-user-menu.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Legacy User Menu</p>
      ");
            WriteLiteral(@"              </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/language-menu.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Language Menu</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/404.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Error 404</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/500.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Error 500</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/pace.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
 ");
            WriteLiteral(@"                       <p>Pace</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../examples/blank.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Blank Page</p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""../../starter.html"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Starter Page</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-header"">MISCELLANEOUS</li>
        <li class=""nav-item"">
            <a href=""https://adminlte.io/docs/3.0"" class=""nav-link"">
                <i class=""nav-icon fas fa-file""></i>
                <p>Documentation</p>
            </a>
        </li>
        <li class=""nav-header"">MULTI LEVEL EXAMPLE</li>
        <li class=""nav-item"">
        ");
            WriteLiteral(@"    <a href=""#"" class=""nav-link"">
                <i class=""fas fa-circle nav-icon""></i>
                <p>Level 1</p>
            </a>
        </li>
        <li class=""nav-item has-treeview"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon fas fa-circle""></i>
                <p>
                    Level 1
                    <i class=""right fas fa-angle-left""></i>
                </p>
            </a>
            <ul class=""nav nav-treeview"">
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Level 2</p>
                    </a>
                </li>
                <li class=""nav-item has-treeview"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>
                            Level 2
                            <i class=""right fas fa-angl");
            WriteLiteral(@"e-left""></i>
                        </p>
                    </a>
                    <ul class=""nav nav-treeview"">
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-link"">
                                <i class=""far fa-dot-circle nav-icon""></i>
                                <p>Level 3</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-link"">
                                <i class=""far fa-dot-circle nav-icon""></i>
                                <p>Level 3</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-link"">
                                <i class=""far fa-dot-circle nav-icon""></i>
                                <p>Level 3</p>
                            </a>
                        </li>
                  ");
            WriteLiteral(@"  </ul>
                </li>
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""far fa-circle nav-icon""></i>
                        <p>Level 2</p>
                    </a>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a href=""#"" class=""nav-link"">
                <i class=""fas fa-circle nav-icon""></i>
                <p>Level 1</p>
            </a>
        </li>
        <li class=""nav-header"">LABELS</li>
        <li class=""nav-item"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon far fa-circle text-danger""></i>
                <p class=""text"">Important</p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""#"" class=""nav-link"">
                <i class=""nav-icon far fa-circle text-warning""></i>
                <p>Warning</p>
            </a>
        </li>
        <li class=""nav-item"">
            <a ");
            WriteLiteral("href=\"#\" class=\"nav-link\">\r\n                <i class=\"nav-icon far fa-circle text-info\"></i>\r\n                <p>Informational</p>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</nav>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591