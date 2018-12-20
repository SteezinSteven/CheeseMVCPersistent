using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: Category
        public IActionResult Index()
        {
            List<CheeseCategory> categories = context.Categories.ToList();
            return View(categories);

        }

        public IActionResult Add()
        {
            AddCategoryViewModel catViewModel = new AddCategoryViewModel();
            return View(catViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel catviewmodel)
        {
            if (ModelState.IsValid)
            {
                CheeseCategory newCategory = new CheeseCategory { Name = catviewmodel.Name
                };
                context.Categories.Add(newCategory);
                context.SaveChanges();
                return Redirect("/Category");
            }
            
            return View(catviewmodel);
        }

    }  
}