using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size teaSize;
        private bool isSweet;

        /// <summary>
        /// Adjusts calories based on size and sweetener of the tea.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return isSweet;
            }
            set
            {
                isSweet = value;
                switch (this.Size)
                    {
                    case Size.Small:
                        if (value && this.Calories == 8)
                           this.Calories = 16;
                        else if (!value && this.Calories != 8)
                            this.Calories = 8;
                        break;
                    case Size.Medium:
                         if (value && this.Calories == 16)
                            this.Calories = 32;
                        else if (!value && this.Calories != 16)
                            this.Calories = 16;
                        break;
                    case Size.Large:
                        if (value && this.Calories == 32)
                                this.Calories = 64;
                        else if (!value && this.Calories != 32)
                            this.Calories = 32;
                        break;
                    }
            }
        }


        public bool Lemon { get; set; }

        /// <summary>
        /// Basic Constructor for the Water Drink Class
        /// </summary>
        public Tyrannotea() : base()
        {
           // this.Sweet = false;
            isSweet = false;
            this.Lemon = false;
        }

        /// <summary>
        /// Returns a list of the ingredients whether or not sweetener or lemon is added.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water", "Tea" };
                if (isSweet)
                {
                    ingredients.Add("Cane Sugar");
                }
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adjusts the price and the calories of the drinks dependant on the size
        /// </summary>
        public override Size Size
        {
            get
            {
                return teaSize;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 8;
                    teaSize = Size.Small;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.49;
                    this.Calories = 16;
                    teaSize = Size.Medium;
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.99;
                    this.Calories = 32;
                    teaSize = Size.Large;
                }
            }
        }
        /// <summary>
        /// Sets the Lemon Property to true.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
