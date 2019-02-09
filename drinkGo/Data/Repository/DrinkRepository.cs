using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drinkGo.Interfaces;
using drinkGo.Models;
using Microsoft.EntityFrameworkCore;

namespace drinkGo.Data.Repository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly MyAppDbContext _appContext;

        public DrinkRepository(MyAppDbContext myAppDbContext)
        {
            _appContext = myAppDbContext;
        }


        public IEnumerable<Drink> Drinks
        {
            get { return _appContext.Drinks.Include(c => c.Category); }
        }

        public IEnumerable<Drink> PreferreDrinks
        {
            get => _appContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);
        }
        public Drink GetDrinkById(int id)
        {
            return _appContext.Drinks.FirstOrDefault(p => p.Id == id);
        }
    }
}
