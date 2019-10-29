using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private double sidePrice = 0;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price {
            get {
                return sidePrice;
            }
            set {
                this.sidePrice = value;
                NotifyPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        public abstract string Description { get; }

        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

     
    }
}
