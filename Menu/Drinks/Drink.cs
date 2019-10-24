using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{ 
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private double drinkPrice;
        public double Price 
        {
            get
            {
                return drinkPrice;
            }
            set
            {
                NotifyPropertyChanged("Price");
                drinkPrice = value;
            }
        }

        public uint Calories { get; set; }

        public abstract List<String> Ingredients { get; }

        public abstract Size Size { get; set; }

        public bool Ice { get; set; }

        public abstract string Description { get; }

        public abstract string [] Special { get; }

        /// <summary>
        /// Basic Constructor for the parent Drink Class
        /// </summary>
        public Drink()
        {
            drinkPrice = 0;
            this.Ice = true;
            Size = Size.Small;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Method to set the Ice property to false as per the desire of the customer.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
            NotifyPropertyChanged("Ice");
            NotifyPropertyChanged("Special");
        }

    }
}
