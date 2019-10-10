using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {

        public List<string> AvailableMenuItems { get; }
        public List<string> AvailableDrinks { get; }
        public List<string> AvailableSides { get; }
        public List<string> AvailableEntrees { get; }
        public Menu()
        {
            this.AvailableMenuItems.Add("Jurassic Java");
            this.AvailableMenuItems.Add("Sodasaurus");
            this.AvailableMenuItems.Add("Water");
            this.AvailableMenuItems.Add("Tyrannotea");

            this.AvailableMenuItems.Add("Triceritots");
            this.AvailableMenuItems.Add("Mezzorella Sticks");
            this.AvailableMenuItems.Add("Meteor Mac and Cheese");
            this.AvailableMenuItems.Add("Fryceritops");
            this.AvailableMenuItems.Add("Triceritots");

            this.AvailableMenuItems.Add("Velociwrap");
            this.AvailableMenuItems.Add("T-Rex King Burger");
            this.AvailableMenuItems.Add("Pterodactyl Wings");
            this.AvailableMenuItems.Add("Prehistoric PB&J");
            this.AvailableMenuItems.Add("Steakosaurus Burger");
            this.AvailableMenuItems.Add("Brontowurst");
            this.AvailableMenuItems.Add("Dino-Nuggets");

            this.AvailableDrinks.Add("Jurassic Java");
            this.AvailableDrinks.Add("Sodasaurus");
            this.AvailableDrinks.Add("Water");
            this.AvailableDrinks.Add("Tyrannotea");

            this.AvailableSides.Add("Triceritots");
            this.AvailableSides.Add("Mezzorella Sticks");
            this.AvailableSides.Add("Meteor Mac and Cheese");
            this.AvailableSides.Add("Fryceritops");
            this.AvailableSides.Add("Triceritots");

            this.AvailableEntrees.Add("Velociwrap");
            this.AvailableEntrees.Add("T-Rex King Burger");
            this.AvailableEntrees.Add("Pterodactyl Wings");
            this.AvailableEntrees.Add("Prehistoric PB&J");
            this.AvailableEntrees.Add("Steakosaurus Burger");
            this.AvailableEntrees.Add("Brontowurst");
            this.AvailableEntrees.Add("Dino-Nuggets");
        }
    
        public string toString()
        {
            string st = "";
            foreach(string s in AvailableMenuItems)
            {
                st += s + "\n";
            }
            return st;
        }
    }
}
