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
            Order ft = new Order();
            ft.Items.Add(v);
            ft.Items.Add(t);
            ft.Items.Add(w);
            Assert.Equal(7.95, ft.SubtotalCost);
            Assert.Equal(.1 , ft.SalesTaxRate);
            Assert.Equal(ft.SubtotalCost * ft.SalesTaxRate, ft.SalesTaxCost);
            Assert.Equal(ft.SubtotalCost + ft.SalesTaxCost, ft.TotalCost);

        }
        [Fact]
        public void CheckSubtotalCostIsNotNegative()
        {
            Water w = new Water();
            w.Price = -1.00;
            Order ft = new Order();
            ft.Items.Add(w);
            Assert.Equal(0, ft.SubtotalCost);
        }
    }
}