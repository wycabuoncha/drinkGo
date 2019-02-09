using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkGo.Interfaces;
using drinkGo.Models;

namespace drinkGo.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly  MyAppDbContext _myAppDbContext;

        public CategoryRepository(MyAppDbContext myAppDbContext)
        {
            _myAppDbContext = myAppDbContext;
        }
        public IEnumerable<Category> Categories => _myAppDbContext.Categories;
    }
}
