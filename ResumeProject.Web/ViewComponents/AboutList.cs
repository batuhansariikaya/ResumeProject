using Microsoft.AspNetCore.Mvc;
using ResumeProject.Application.Repositories;

namespace ResumeProject.Web.ViewComponents
{
    public class AboutList:ViewComponent
    {
        private readonly IAboutReadRepository _aboutReadRepository;

        public AboutList(IAboutReadRepository aboutReadRepository)
        {
            _aboutReadRepository = aboutReadRepository;
        }
        public IViewComponentResult Invoke()
        {
            var datas= _aboutReadRepository.GetAll();
            return View(datas);
        }
    }
}
