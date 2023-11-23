using System;
using CourseWork.Areas.Admin.Models;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IngredientController : Controller
    {
        private readonly IIngredientRepository _repository;

        public IngredientController(IIngredientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Create(string id, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            return View(new IngredientViewModel { ReturnUrl = returnUrl, IngredientListId = guid });
        }

        [HttpPost]
        public IActionResult Create(IngredientViewModel model)
        {
            var entity = new Ingredient
            {
                Name = model.Name,
                Amount = model.Amount,
                Unit = model.Unit,
                IngredientListId = model.IngredientListId
            };
            _repository.Save(entity);
            return Redirect(model.ReturnUrl);
        }

        [HttpGet]
        public IActionResult Edit(string id, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            ViewBag.ReturnUrl = returnUrl;
            return View(_repository.Get(guid));
        }

        [HttpPost]
        public IActionResult Edit(Ingredient entity, string returnUrl)
        {
            _repository.Save(entity);
            return Redirect(returnUrl ?? "/");
        }

        [HttpGet]
        public IActionResult Delete(string id, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(id) || !Guid.TryParse(id, out var guid)) return NotFound();
            _repository.Delete(guid);
            return Redirect(returnUrl);
        }
    }
}