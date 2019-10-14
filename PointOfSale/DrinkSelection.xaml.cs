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
 * DrinkSelection.xaml.cs
 * Braden Purcell
 * 
 * This class Models the DrinkSelection page of the User Interface. It adjusts visibility of the buttons depending on the drink the user selects.
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private bool isSoda;
        private bool isTea;
        private bool isCoffee;
        private bool isWater;
        public DrinkSelection()
        {
            InitializeComponent();
            isSoda = false;
            isTea = false;
            isCoffee = false;
            isWater = false;
        }

        /// <summary>
        /// This method is the click event for the sodasaurus button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SodasaurusClick(object sender, RoutedEventArgs args)
        {
            isSoda = true;
            isTea = false;
            isCoffee = false;
            isWater = false;
            addLemonButton.Visibility = Visibility.Collapsed;
            creamButton.Visibility = Visibility.Collapsed;
            decafButton.Visibility = Visibility.Collapsed;
            sweetButton.Visibility = Visibility.Collapsed;
            flavorButton.Visibility = Visibility.Visible;
            
        }

        /// <summary>
        /// This method is the click event for the tyrannotea button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TyrannoteaClick(object sender, RoutedEventArgs args)
        {
            isTea = true;
            isSoda = false;
            isCoffee = false;
            isWater = false;
            addLemonButton.Visibility = Visibility.Visible;
            creamButton.Visibility = Visibility.Collapsed;
            decafButton.Visibility = Visibility.Collapsed;
            sweetButton.Visibility = Visibility.Visible;
            flavorButton.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// This method is the click event for the Jurassic Java button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void JurassicJavaClick(object sender, RoutedEventArgs args)
        {
            isTea = false;
            isSoda = false;
            isCoffee = true;
            isWater = false;
            addLemonButton.Visibility = Visibility.Collapsed;
            creamButton.Visibility = Visibility.Visible;
            decafButton.Visibility = Visibility.Visible;
            sweetButton.Visibility = Visibility.Collapsed;
            flavorButton.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// This method is the click event for the water button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void WaterClick(object sender, RoutedEventArgs args)
        {
            isTea = false;
            isSoda = false;
            isCoffee = false;
            isWater = true;
            addLemonButton.Visibility = Visibility.Visible;
            creamButton.Visibility = Visibility.Collapsed;
            decafButton.Visibility = Visibility.Collapsed;
            sweetButton.Visibility = Visibility.Collapsed;
            flavorButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// This method is the click event for the flavor button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void FlavorClick(object sender, RoutedEventArgs args)
        {
            if (isSoda)
            {
                NavigationService.Navigate(new FlavorSelection());
            }
        }
    }
}
