using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        private ObservableCollection<IOrderItem> items;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<IOrderItem> Items
        {
            get => items;
            set
            {
                if (items != null) items.CollectionChanged -= ItemChangeEvent;
                items = value;
                if (items != null) items.CollectionChanged += ItemChangeEvent;
            }
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += UpdatePropertyChanged;
            items.Add(item);
            NotifyPropertyChanged("Items");
            NotifyPropertyChanged("SubtotalCost");

        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            NotifyPropertyChanged("Items");
            NotifyPropertyChanged("SubtotalCost");
        }

        private void ItemChangeEvent(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }

        private void UpdatePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }

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

        public Order()
        {
            this.Items = new ObservableCollection<IOrderItem>();
            this.SalesTaxRate = .1;
        }
    }
}
