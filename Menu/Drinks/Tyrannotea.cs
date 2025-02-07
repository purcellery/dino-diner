﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
                NotifyPropertyChanged("Sweet");
                NotifyPropertyChanged("Description");
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
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Medium)
                {
                    this.Price = 1.49;
                    this.Calories = 16;
                    teaSize = Size.Medium;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.99;
                    this.Calories = 32;
                    teaSize = Size.Large;
                    NotifyPropertyChanged("Size");
                    NotifyPropertyChanged("Description");
                }
            }
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

        public void NoLemon()
        {
            this.Lemon = false;
            NotifyPropertyChanged("Lemon");
            NotifyPropertyChanged("Special");
        }

        public override string ToString()
        {
            string s = "";
            if (teaSize == Size.Small) s += "Small ";
            else if (teaSize == Size.Medium) s += "Medium ";
            else if (teaSize == Size.Large) s += "Large ";

            if (this.Sweet) s += "Sweet ";
            return s + "Tyrannotea";
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
                if (!Ice)
                {
                    s.Add("Hold Ice");
                }
                if (Lemon)
                {
                    s.Add("Add Lemon");
                }
                return s.ToArray();
            }
        }
    }
}
