using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace drinkGo.Models
{
    [Table("Category")]
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        //Category can have multiple drins.
        public List<Drink> Drinks { get; set; }

    }
}