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
 * FlavorSelection.xaml.cs
 * Braden Purcell
 * 
 * This class Models the FlavorSelection page of the User Interface.
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public void ColaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cola;
                    DrinkSelection d = new DrinkSelection();

                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }

        public void VanillaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Vanilla;
                    DrinkSelection d = new DrinkSelection();

                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }

        public void RootBeerClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.RootBeer;
                    DrinkSelection d = new DrinkSelection();
                    
                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }
        
        public void CherryClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cherry;
                    DrinkSelection d = new DrinkSelection();

                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }

        public void LimeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Lime;
                    DrinkSelection d = new DrinkSelection();

                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }

        public void ChocolateClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Chocolate;
                    DrinkSelection d = new DrinkSelection();

                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }

        public void OrangeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Orange;
                    DrinkSelection d = new DrinkSelection();

                    d.addLemonButton.Visibility = Visibility.Collapsed;
                    d.creamButton.Visibility = Visibility.Collapsed;
                    d.decafButton.Visibility = Visibility.Collapsed;
                    d.sweetButton.Visibility = Visibility.Collapsed;
                    d.flavorButton.Visibility = Visibility.Visible;
                    NavigationService.Navigate(d);
                }
            }
        }
    }
}
