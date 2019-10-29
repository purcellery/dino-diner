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
using System.Windows.Navigation;
using System.Windows.Shapes;

/**
 * MainWindow.xaml.cs
 * Braden Purcell
 * 
 * This class Models the MainWindow page of the User Interface. It acts as the base that is referred to by the other windows.
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SuperMegaControllerNeo.EpicAwesomeListOfItems.SelectionChanged += ItemsList_SelectionChanged;
        }

        private void ItemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (frame.Content is DrinkSelection d)
            {
                if (DataContext is Order order)
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                    {
                        if (drink is Sodasaurus)
                        {
                            d.addLemonButton.Visibility = Visibility.Collapsed;
                            d.creamButton.Visibility = Visibility.Collapsed;
                            d.decafButton.Visibility = Visibility.Collapsed;
                            d.sweetButton.Visibility = Visibility.Collapsed;
                            d.flavorButton.Visibility = Visibility.Visible;
                        }
                        if (drink is Tyrannotea)
                        {
                            d.addLemonButton.Visibility = Visibility.Visible;
                            d.creamButton.Visibility = Visibility.Collapsed;
                            d.decafButton.Visibility = Visibility.Collapsed;
                            d.sweetButton.Visibility = Visibility.Visible;
                            d.flavorButton.Visibility = Visibility.Collapsed;
                        }
                        if (drink is JurassicJava)
                        {
                            d.addLemonButton.Visibility = Visibility.Collapsed;
                            d.creamButton.Visibility = Visibility.Visible;
                            d.decafButton.Visibility = Visibility.Visible;
                            d.sweetButton.Visibility = Visibility.Collapsed;
                            d.flavorButton.Visibility = Visibility.Collapsed;
                        }
                        if (drink is Water)
                        {
                            d.addLemonButton.Visibility = Visibility.Visible;
                            d.creamButton.Visibility = Visibility.Collapsed;
                            d.decafButton.Visibility = Visibility.Collapsed;
                            d.sweetButton.Visibility = Visibility.Collapsed;
                            d.flavorButton.Visibility = Visibility.Collapsed;
                        }
                    }
                }
            }
        }

        private void DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassDataContext();
        }

        private void Load_Completed(object sender, NavigationEventArgs args)
        {
            PassDataContext();
        }

        private void PassDataContext()
        {
            if(frame.Content is Page page)
            {
                page.DataContext = DataContext;
            }
        }
    }
}
