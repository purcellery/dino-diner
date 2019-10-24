
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// Returns a list with all of the ingredients in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie","Steakburger Pattie","Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");

                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public TRexKingBurger()
        {
           this.Price = 8.45;
           this.Calories = 728;
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
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyPropertyChanged("Lettuce");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyPropertyChanged("Tomato");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyPropertyChanged("Onion");
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

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyPropertyChanged("Mayo");
            NotifyPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!lettuce)
                {
                    s.Add("Hold Lettuce");
                }
                if (!tomato)
                {
                    s.Add("Hold Tomato");
                }
                if (!onion)
                {
                    s.Add("Hold Onion");
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
                if (!mayo)
                {
                    s.Add("Hold Mayo");
                }
                return s.ToArray();
            }
        }
    }
}
