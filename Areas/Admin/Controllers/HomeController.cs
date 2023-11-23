using CourseWork.Areas.Admin.Models;
using CourseWork.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager);
        }
    }
}