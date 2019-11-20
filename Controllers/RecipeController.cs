using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeAssignment.Models;

namespace RecipeAssignment.Controllers
{
    public class RecipeController : Controller
    {
        /*private IRecipeRepo repository;

        public RecipeController(IRecipeRepo repo)
        {
            repository = repo;
        }*/

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult InsertPage()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InsertPage(Recipe recipe)
        {
            IRecipeRepo.AddRecipe(recipe);
            return View("DataPage", IRecipeRepo.Recipes);
        }
        public ViewResult DisplayPage()
        {
            return View(IRecipeRepo.Recipes);
        }
        public ViewResult DataPage()
        {
            return View(IRecipeRepo.Recipes);
        }
        [HttpGet]
        public ViewResult UserPage()
        {
            return View();
        }
        [HttpPost]
        public ViewResult UserPage(Recipe recipe)
        {
            return View("DisplayPage", IRecipeRepo.Recipes);
        }

    }
}