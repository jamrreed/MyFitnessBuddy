using MyFitnessBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFitnessBuddy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Workout");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Workout()
        {
            return View();
        }

        public ActionResult Nutrition()
        {
            NutritionModel model = new NutritionModel();
            model.Foods.Add(new MyFitnessBuddy.Food() { nCalories = 50, nFat = 9, nCarb = 2, nProtein = 2 });
            model.Foods.Add(new MyFitnessBuddy.Food() { nCalories = 35, nFat = 0, nCarb = 3, nProtein = 5 });
            model.Foods.Add(new MyFitnessBuddy.Food() { nCalories = 125, nFat = 0, nCarb = 12, nProtein = 25 });
            model.Foods.Add(new MyFitnessBuddy.Food() { nCalories = 200, nFat=15, nCarb = 30, nProtein = 15 });
            model.Foods.Add(new MyFitnessBuddy.Food() { nCalories = (decimal)158.5, nFat = 20, nCarb = 5, nProtein = 20 });

            return View(model);
        }
    }
}