using System;
using System.IO;
using System.Threading.Tasks;
using CourseWork.Areas.Admin.Models;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RecipeController : Controller
    {
        private readonly IRecipeRepository _repository;
        private readonly IWebHostEnvironment _env;

        public RecipeController(IRecipeRepository repository, IWebHostEnvironment env)
        {
            _repository = repository;
            _env = env;
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            var model = new RecipeViewModel();  
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RecipeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var entity = new Recipe
            {
                ImageName = await UploadImage(model.Image),
                Title = model.Title,
                Category = model.Category,
                Description = model.Description,
                Difficulty = model.Difficulty,
                PrepareTime = model.PrepareTime,
                CookTime = model.CookTime,
            };
            _repository.Save(entity);
            return RedirectToAction("Index", "Home");
        }

        public async Task<string> UploadImage(IFormFile file)
        {
            var rootPath = _env.WebRootPath;
            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
            var extension = Path.GetExtension(file.FileName);

            var result = fileName + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + extension;
                
            var path = Path.Combine(rootPath + "/images/", result);
            
            await using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return result;
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            return View(_repository.Get(guid));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                if (recipe.ImageFile != null)
                {
                    recipe.ImageName = await UploadImage(recipe.ImageFile);
                }
                _repository.Save(recipe);
                return RedirectToAction("Index", "Home");
            }

            return View(recipe);
        }

        [HttpGet]
        public IActionResult Delete(string id, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            _repository.Delete(guid);
            return Redirect(returnUrl ?? "/");
        }

        [HttpGet]
        public IActionResult AddStep(string recipeId)
        {
            if (string.IsNullOrWhiteSpace(recipeId) || !Guid.TryParse(recipeId, out var guid)) return NotFound();
            var recipe = _repository.Get(guid);
            ViewBag.Index = recipe.Steps.Count;
            recipe.Steps.Add("");
            return View(recipe);
        }

        [HttpPost]
        public IActionResult AddStep(Recipe entity)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(entity);
                return RedirectToAction("Edit", new { id = entity.Id.ToString() });
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult RemoveStep(string recipeId, int i)
        {
            if (string.IsNullOrWhiteSpace(recipeId) || !Guid.TryParse(recipeId, out var guid)) return NotFound();
            var recipe = _repository.Get(guid);
            recipe.Steps.RemoveAt(i);
            _repository.Save(recipe);
            return RedirectToAction("Edit", new { id = recipe.Id.ToString() });
        }
    }
}