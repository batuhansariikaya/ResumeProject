using Microsoft.AspNetCore.Mvc;

namespace ResumeProject.Web.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
