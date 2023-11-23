using System;
using CourseWork.Areas.Admin.Models;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IngredientListController : Controller
    {
        private readonly IIngredientListRepository _repository;

        public IngredientListController(IIngredientListRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Create(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            return View(new IngredientListViewModel {RecipeId = guid});
        }

        [HttpPost]
        public IActionResult Create(IngredientListViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new IngredientList
                {
                    Purpose = model.Purpose,
                    RecipeId = model.RecipeId
                };
                _repository.Save(entity);
                return RedirectToAction("Edit", "Recipe", new { id = model.RecipeId });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            return View(_repository.Get(guid));
        }

        [HttpPost]
        public IActionResult Edit(IngredientList entity)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(entity);
                return RedirectToAction("Edit", "Recipe", new { id = entity.RecipeId});
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(string id, string recipeId)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            if (string.IsNullOrWhiteSpace(recipeId) || !Guid.TryParse(recipeId, out var recipeGuid)) return NotFound();
            _repository.Delete(guid);
            return RedirectToAction("Edit", "Recipe", new { id = recipeGuid });
        }
    }
}