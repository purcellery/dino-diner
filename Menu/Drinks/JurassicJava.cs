using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
        }

        /// <summary>
        /// Adds Ice to the JurassicJava as per the desire of the customer.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
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
    }
}
