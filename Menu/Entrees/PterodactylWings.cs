using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        public override int Mods { get; } = 0;

        public override void SwitchBoolByID(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns a list with all of the ingredients in the entree
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor to set price and calories for the entree
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
        public override string ToString()
        {
            return "Pterodactyl Wings";
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
                return s.ToArray();
            }
        }
    }
}
