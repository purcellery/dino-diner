using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public override int Mods { get; } = 2;

        public override void SwitchBoolByID(int id)
        {
            switch (id)
            {
                case 1:
                    peanutButter = !peanutButter;
                    break;
                case 2:
                    jelly = !jelly;
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
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyPropertyChanged("Peanut Butter");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the selected ingredient if the customer desires to do so.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyPropertyChanged("Jelly");
            NotifyPropertyChanged("Special");
        }
        public override string ToString()
        {
            return "Prehistoric PB&J";
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
                if (!peanutButter)
                {
                    s.Add("Hold Peanut Butter");
                }
                if (!jelly)
                {
                    s.Add("Hold Jelly");
                }
                return s.ToArray();
            }
        }
    }
}
