using System.Collections.Generic;


namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Returns a list with all of the ingredients in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");

                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyPropertyChanged("Bun");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyPropertyChanged("Pickle");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyPropertyChanged("Ketchup");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyPropertyChanged("Mustard");
            NotifyPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Steakosaurus Burger";
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
                if (!bun)
                {
                    s.Add("Hold Bun");
                }
                if (!pickle)
                {
                    s.Add("Hold Pickle");
                }
                if (!mustard)
                {
                    s.Add("Hold Mustard");
                }
                if (!ketchup)
                {
                    s.Add("Hold Ketchup");
                }
                return s.ToArray();
            }
        }
    }
}
