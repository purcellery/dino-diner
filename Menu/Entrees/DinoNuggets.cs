using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        private int nuggetCount = 6;

        public override int Mods { get; } = 2;

        public override void SwitchBoolByID(int id)
        {
            switch (id)
            {
                case 1:
                    AddNugget();
                    break;
                case 2:
                    RemoveNugget();
                    break;
            }
            NotifyPropertyChanged("Price");
            NotifyPropertyChanged("Calories");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Returns a list with all of the ingredients in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// Adds a nugget to the entree
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            this.Price += .25;
            this.Calories += 59;
            NotifyPropertyChanged("Price");
            NotifyPropertyChanged("Calories");
            NotifyPropertyChanged("Special");
        }
        public void RemoveNugget()
        {
            if(nuggetCount > 6)
            {
                nuggetCount--;
                this.Price -= 0.25;
                this.Calories -= 59;
                Ingredients.Remove("Chicken Nugget");

                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("Special");
            }
        }

        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if(nuggetCount > 6)
                {
                    s.Add((nuggetCount - 6) + " Extra Nuggets");
                }
                return s.ToArray();
            }
        }
    }
}
