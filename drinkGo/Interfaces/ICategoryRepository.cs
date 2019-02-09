using System.Collections;
using System.Collections.Generic;
using drinkGo.Models;

namespace drinkGo.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories{ get; }
    }
}