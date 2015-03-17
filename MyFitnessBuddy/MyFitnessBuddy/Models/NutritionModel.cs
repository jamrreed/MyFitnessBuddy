using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFitnessBuddy.Models
{
    public class NutritionModel
    {
        [DisplayName("Date")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Date { get; set; }

        [DisplayName("Time")]
        [Required(ErrorMessage="Time is required.")]
        public string Time { get; set; }
        public SelectList slTimes { get; set; }

        public Food FoodSelected { get; set; }
        public double QuantityAdded { get; set; }

        public List<Food> FoodsAll { get; set; }
        public List<Food> FoodsToday { get; set; }
        public Dictionary<string, List<Food>> TimesFoodsToday { get; set; }

        public SelectList slAllFoods { get; set; }

        public NutritionModel()
        {
            Date = DateTime.Now.ToShortDateString();
            FoodsAll = new List<Food>();
            FoodsToday = new List<Food>();
            TimesFoodsToday = new Dictionary<string, List<Food>>();
            SetupTimes();
        }

        private void SetupTimes()
        {
            List<string> lstTimes = new List<string>(){
                "7:00 AM", "7:30 AM", "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM",
                "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM", "4:30 PM",
                "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM", "7:30 PM", "8:00 PM", "8:30 PM", "9:00 PM", "9:30 PM",
                "10:00 PM", "10:30 PM", "11:00 PM", "11:30 PM", "12:00 AM", "12:30 AM", "1:00 AM", "1:30 AM", "2:00 AM", "2:30 AM",
                "3:00 AM", "3:30 AM", "4:00 AM", "4:30 AM", "5:00 AM", "5:30 AM", "6:00 AM", "6:30 AM", 
            };
            slTimes = new SelectList(lstTimes);
            foreach (string str in lstTimes)
            {
                TimesFoodsToday.Add(str, new List<Food>());
            }
        }
    }
}