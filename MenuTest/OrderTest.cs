using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void checkOrderCalculations()
        {
            VelociWrap v = new VelociWrap();
            Triceritots t = new Triceritots();
            Water w = new Water();
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            order.Add(v);
            order.Add(t);
            order.Add(w);
            Order ft = new Order(order, .1);
            Assert.Equal(7.95, ft.SubtotalCost);
            Assert.Equal(.1 , ft.SalesTaxRate);
            Assert.Equal(ft.SubtotalCost * ft.SalesTaxRate, ft.SalesTaxCost);
            Assert.Equal(ft.SubtotalCost + ft.SalesTaxCost, ft.TotalCost);

        }
        [Fact]
        public void CheckSubtotalCostIsNotNegative()
        {
            Water w = new Water();
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            w.Price = -1.00;
            order.Add(w);
            Order ft = new Order(order, .1);
            Assert.Equal(0, ft.SubtotalCost);
        }
    }
}