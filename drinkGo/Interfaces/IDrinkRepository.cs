using System.Collections;
using System.Collections.Generic;
using drinkGo.Models;

namespace drinkGo.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks  { get;}

        IEnumerable<Drink> PreferreDrinks { get;}

        Drink GetDrinkById(int id);
    }
}
