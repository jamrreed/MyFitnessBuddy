using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyFitnessBuddy.Models
{
    public class AllFoodsModel
    {
        public Food SelectedFood { get; set; }
        public SelectList slFoods { get; set; }
    }
}
