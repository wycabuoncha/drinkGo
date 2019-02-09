using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkGo.Interfaces;
using drinkGo.Models;

namespace drinkGo.Data.Mock
{
    public class MockCategory : ICategoryRepository
    {
        public IEnumerable<Category> Categories =>
            new  List<Category>
            {
                new Category{ CategoryName = "Alcoholic", Description = "All Alcoholic drinks"},
                new Category{CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks"},
                new Category{ CategoryName = "Alcoholic", Description = "All Alcoholic drinks"},
                new Category{CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks"},
                new Category{ CategoryName = "Alcoholic", Description = "All Alcoholic drinks"},
                new Category{CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks"},
                new Category{ CategoryName = "Alcoholic", Description = "All Alcoholic drinks"},
                new Category{CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks"}
            };
    }
}
