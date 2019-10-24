using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        private Size waterSize;
        public bool Lemon { get; set; }

        /// <summary>
        /// Basic Constructor for the Water Drink Class
        /// </summary>
        public Water() : base()
        {
            this.Lemon = false;
        }

        /// <summary>
        /// Sets the Lemon Property to true.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyPropertyChanged("Lemon");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// This method keeps the price and calories stagnant despite the size of the water.
        /// </summary>
        public override Size Size
        {
            get
            {
                return waterSize;
            }
            set
            {
                this.Price = .10;
                this.Calories = 0;
                waterSize = value;
                NotifyPropertyChanged("Size");
            }
        }
        
        /// <summary>
        /// Gets the Ingredients in water whether or not a lemon is added.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<String> ingredients = new List<String> { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        public override string ToString()
        {
            string s = "";
            if (waterSize == Size.Small) s += "Small ";
            else if (waterSize == Size.Medium) s += "Medium ";
            else if (waterSize == Size.Large) s += "Large ";
            return s + "Water";
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> s = new List<string>();
                if (Lemon)
                {
                    s.Add("Add Lemon");
                }
                if (!Ice)
                {
                    s.Add("Hold Ice");
                }
                return s.ToArray();
            }
        }
    }
}
