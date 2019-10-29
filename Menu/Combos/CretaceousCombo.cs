using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables
        private Size size;
        private Entree e;
        private Drink d;
        private Side cs;

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return e;
            }
            set 
            {
                this.e = value;
                NotifyPropertyChanged("Entree");
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side {
            get
            {
                return this.cs;
            }
            set
            {
                this.cs = value;
                NotifyPropertyChanged("Side");
            }
        }

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
                NotifyPropertyChanged("Drink");
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public string Description => ToString();

        public string[] Special
        {
            get
            {
                List<string> s = new List<string>();
                s.AddRange(Entree.Special);
                s.Add(Side.Description);
                s.AddRange(Side.Special);
                s.Add(Drink.Description);
                s.AddRange(Drink.Special);
                return s.ToArray();
            }
        }


        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            e = entree;
            this.d = new Sodasaurus();
            this.cs = new Fryceritops();
        }

        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
