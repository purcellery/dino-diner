using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public IEnumerable<IMenuItem>[] Items;

        public Menu menu { get; private set; } = new Menu();
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<String>();
        [BindProperty]
        public double? minimumPrice { get; set; }
        [BindProperty]
        public double? maximumPrice { get; set; }
        [BindProperty]
        public List<string> exclusiveIngredients { get; set; } = new List<String>();

        public void OnGet()
        {
            menu = new Menu();
            Items = new IEnumerable<IMenuItem>[] { menu.AvailableCombos, menu.AvailableDrinks, menu.AvailableEntrees, menu.AvailableSides };
        }

        public void OnPost()
        {
            Items = new IEnumerable<IMenuItem>[] { menu.AvailableCombos, menu.AvailableDrinks, menu.AvailableEntrees, menu.AvailableSides};
            //Search 
            for (int i = 0; i < 4; i++)
            {
                if (search != null)
                {
                    Items[i] = Items[i].Where(menuItem =>
                                                menuItem.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                }

                if (menuCategory.Count > 0)
                {
                    Items[i] = Items[i].Where(menuItem =>
                                                (menuItem is CretaceousCombo && menuCategory.Contains("Combo"))
                                                || (menuItem is Entree && menuCategory.Contains("Entree"))
                                                || (menuItem is Drink && menuCategory.Contains("Drink"))
                                                || (menuItem is Side && menuCategory.Contains("Side")));

                }
                if (minimumPrice is double min)
                {
                    Items[i] = Items[i].Where(menuItem =>
                                                (menuItem.Price >= min));
                }
                if (maximumPrice is double max)
                {
                    Items[i] = Items[i].Where(menuItem =>
                                                (menuItem.Price <= max));
                }
                if(exclusiveIngredients.Count > 0)
                {
                    Items[i] = Items[i].Where(menuItem =>
                                                (exclusiveIngredients.Intersect(menuItem.Ingredients).Count() == 0));
                }
            }
        }
    }
}