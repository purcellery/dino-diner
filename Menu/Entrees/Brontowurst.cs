using System.Collections.Generic;

namespace DinoDiner.Menu

{
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool onions = true;
        private bool peppers = true;

        /// <summary>
        /// Returns a list with all of the ingredients in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
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
        public void HoldOnion()
        {
            this.onions = false;
            NotifyPropertyChanged("Onion");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyPropertyChanged("Peppers");
            NotifyPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Brontowurst";
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
                if (!peppers)
                {
                    s.Add("Hold Peppers");
                }
                if (!onions)
                {
                    s.Add("Hold Onions");
                }
                return s.ToArray();
            }
        }
    }
}
