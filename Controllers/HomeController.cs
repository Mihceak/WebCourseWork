using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CourseWork.Domain;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Enums;
using CourseWork.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager, IWebHostEnvironment env)
        {
            _dataManager = dataManager;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Recipe(string id)
        {
            if (String.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            return View(_dataManager.Recipes.Get(guid));
        }

        public IActionResult RecipeList(Category filter)
        {
            ViewBag.Filter = filter;
            return View(_dataManager.Recipes.GetRecipes());
        }

        public IActionResult Test()
        {
            return View(_dataManager);
        }

        public async Task<JsonResult> UploadImage()
        {
            try
            {
                var uploads = Path.Combine(_env.WebRootPath, "images");
                if (!Directory.Exists(uploads)) Directory.CreateDirectory(uploads);
                foreach (var contentFile in Request.Form.Files)
                {
                    if (contentFile is not { Length: > 0 }) continue;
                    await using (var stream = new FileStream($"{uploads}\\{contentFile.FileName}", FileMode.Create))
                    {
                        await contentFile.CopyToAsync(stream);
                    }

                    return Json(new { url = $"https://localhost:5001/images/{contentFile.FileName}" });
                }

                return null;
            }
            catch (Exception e)
            {
                return Json(new { error = new { message = e.Message } });
            }
        }
    }
}