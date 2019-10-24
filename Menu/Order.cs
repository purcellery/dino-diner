using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; }

        public double SubtotalCost
        {
            get
            {
                double sc = 0;

                for(int i = 0; i < Items.Count; i++)
                {
                    sc += Items[i].Price;
                }
                if (sc >= 0) { return sc; }
                else {
                    return 0;
                }
            }
        }

        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost 
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        public double TotalCost 
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }

        public Order(ObservableCollection<IOrderItem> items, double salesTax)
        {
            this.Items = items;
            this.SalesTaxRate = salesTax;
        }
    }
}
