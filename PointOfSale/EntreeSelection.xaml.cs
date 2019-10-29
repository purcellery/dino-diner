using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

/**
 * EntreeSelection.xaml.cs
 * Braden Purcell
 * 
 * This class Models the EntreeSelection page of the User Interface.
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public void EntreeClick(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order) 
            {
                if (sender == BrontowurstButton)
                {
                    order.Items.Add(new Brontowurst());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (sender == VelociwrapButton)
                {
                    order.Items.Add(new VelociWrap());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (sender == SteakosaurusButton)
                {
                    order.Items.Add(new SteakosaurusBurger());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (sender == TRexButton)
                {
                    order.Items.Add(new TRexKingBurger());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (sender == DinoNuggetsButton)
                {
                    order.Items.Add(new DinoNuggets());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (sender == WingsButton)
                {
                    order.Items.Add(new PterodactylWings());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    order.Items.Add(new PrehistoricPBJ());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }
        }
    }
}
