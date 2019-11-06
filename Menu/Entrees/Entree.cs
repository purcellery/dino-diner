using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public abstract void SwitchBoolByID(int id);

        private double entreePrice = 0;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price {
            get
            {
                return this.entreePrice;
            }
            set
            {
                this.entreePrice = value;
                NotifyPropertyChanged("Price");
            }

        }

        public abstract int Mods { get; }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        public abstract string Description { get; }

        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
