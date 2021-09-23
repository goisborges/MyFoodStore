using Microsoft.AspNetCore.Mvc;
using MyFoodStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFoodStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();

            for (var i=0; i < 11; i++)
            {
                categories.Add(new Category()
                {
                    CategoryId = i,
                    Name = "Category " + i.ToString()
                });
            }

            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            //ensure we have a category
            if (category == null)
            {
                return RedirectToAction("Index");
            }

            //store the input parameter inside the ViewBag
            ViewBag.category = category;

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
