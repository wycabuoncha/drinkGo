using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkGo.Models;

namespace drinkGo.ViewModels
{
    public class HomePageViewModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }


        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsPreferredDrink { get; set; }

        public bool InStock { get; set; }

        //Category can have multiple drins.
        public List<Drink> Drinks { get; set; }

        public Category Category { get; set; }
    }
}
