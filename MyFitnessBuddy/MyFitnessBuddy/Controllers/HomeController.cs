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
            model.FoodsAll.Add(new MyFitnessBuddy.Food() { ID = Guid.Parse("AE6B511D-150F-4EE3-84E4-E1C4E8A4169A"), strName="Cheese", nCalories = 50, nFat = 9, nCarb = 2, nProtein = 2 });
            model.FoodsAll.Add(new MyFitnessBuddy.Food() { ID = Guid.Parse("633C6113-95CC-4594-BAA3-185A8C8D91D6"), strName = "Broccoli", nCalories = 35, nFat = 0, nCarb = 3, nProtein = 5 });
            model.FoodsAll.Add(new MyFitnessBuddy.Food() { ID = Guid.Parse("FA154559-A4E6-4B96-9824-9C39A4BDD15D"), strName = "Chicken", nCalories = 125, nFat = 0, nCarb = 12, nProtein = 25 });
            model.FoodsAll.Add(new MyFitnessBuddy.Food() { ID = Guid.Parse("714AADFA-9F1C-4F63-8605-9F8DB5F68887"), strName = "Chips", nCalories = 200, nFat = 15, nCarb = 30, nProtein = 15 });
            model.FoodsAll.Add(new MyFitnessBuddy.Food() { ID = Guid.Parse("49C8AF8C-DE15-41F1-9155-EB9BBB54B144"), strName = "Rice", nCalories = (decimal)158.5, nFat = 20, nCarb = 5, nProtein = 20 });
            
            model.slAllFoods = new SelectList(model.FoodsAll, "ID", "strName");

            return View(model);
        }

        [HttpPost]
        public ActionResult GetFoodInfo(Guid gId)
        {
            double nCalories = 0;
            double nFat = 0;
            double nCarb = 0;
            double nProtein = 0;
            string strComparison = gId.ToString();
            switch (strComparison.ToUpper())
            {
                case "AE6B511D-150F-4EE3-84E4-E1C4E8A4169A":
                    nCalories = 50; nFat = 9; nCarb = 2; nProtein = 2;
                    break;
                case "633C6113-95CC-4594-BAA3-185A8C8D91D6":
                    nCalories = 35; nFat = 0; nCarb = 3; nProtein = 5;
                    break;
                case "FA154559-A4E6-4B96-9824-9C39A4BDD15D":
                    nCalories = 125; nFat = 0; nCarb = 12; nProtein = 25;
                    break;
                case "714AADFA-9F1C-4F63-8605-9F8DB5F68887":
                    nCalories = 200; nFat = 15; nCarb = 30; nProtein = 15;
                    break;
                case "49C8AF8C-DE15-41F1-9155-EB9BBB54B144":
                    nCalories = 158.5; nFat = 20; nCarb = 5; nProtein = 20;
                    break;
                default:
                    break;
            }

            return Json(new { nCalories = nCalories, nFat = nFat, nCarb = nCarb, nProtein = nProtein });
        }
    }
}