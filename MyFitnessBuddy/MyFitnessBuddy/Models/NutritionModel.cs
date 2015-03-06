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

    }
}