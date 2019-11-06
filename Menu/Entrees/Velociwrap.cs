using System.Collections.Generic;


namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        public override int Mods { get; } = 3;

        public override void SwitchBoolByID(int id)
        {
            switch (id)
            {
                case 1:
                    dressing = !dressing;
                    break;
                case 2:
                    cheese = !cheese;
                    break;
                case 3:
                    lettuce = !lettuce;
                    break;

            }
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Returns a list with all of the ingredients in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyPropertyChanged("Dressing");
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
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyPropertyChanged("Cheese");
            NotifyPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Veloci-Wrap";
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
                if (!dressing)
                {
                    s.Add("Hold Dressing");
                }
                if (!lettuce)
                {
                    s.Add("Hold Lettuce");
                }
                if (!cheese)
                {
                    s.Add("Hold Cheese");
                }
                return s.ToArray();
            }
        }
    }
}
