using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink 
    {
        private Size javaSize;
        
        /// <summary>
        /// Basic Constructor for the Water Drink Class
        /// </summary>
        public JurassicJava() : base()
        {
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
        }
        public bool RoomForCream { get; set; }
        public bool Decaf { get; set; }

        /// <summary>
        /// Leaves room for cream on the JurassicJava as per the desire of the customer.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            NotifyPropertyChanged("Room For Cream");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Adds Ice to the JurassicJava as per the desire of the customer.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyPropertyChanged("Ice");
            NotifyPropertyChanged("Special");
        }

        /// <summary>
        /// Returns a list of the ingredients.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee"};
            }
        }

        /// <summary>
        /// Adjusts the price and calories depending on the size of the JurassicJava.
        /// </summary>
        public override Size Size
        {
            get
            {
                return javaSize;
            }
            set
            {
                NotifyPropertyChanged("Size");
                if (value == Size.Small)
                {
                    this.Price = 0.59;
                    this.Calories = 2;
                    javaSize = Size.Small;
                }
                else if (value == Size.Medium)
                {
                    this.Price = 0.99;
                    this.Calories = 4;
                    javaSize = Size.Medium;
                }
                else if (value == Size.Large)
                {
                    this.Price = 1.49;
                    this.Calories = 8;
                    javaSize = Size.Large;
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            if (javaSize == Size.Small) s += "Small ";
            else if (javaSize == Size.Medium) s += "Medium ";
            else if (javaSize == Size.Large) s += "Large ";

            if (this.Decaf) s += "Decaf ";
            return s + "Jurassic Java";
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string [] Special
        {
            get
            {
                List<string> s = new List<string>();
                if (Ice)
                {
                    s.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    s.Add("Add Room For Cream");
                }
                return s.ToArray();
            }
        }
    }
}
