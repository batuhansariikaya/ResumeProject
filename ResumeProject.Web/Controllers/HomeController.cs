using Microsoft.AspNetCore.Mvc;
using ResumeProject.Web.Models;
using System.Diagnostics;

namespace ResumeProject.Web.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            return View();            
        }
    }
}