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
 * MainCategorySelection.xaml.cs
 * Braden Purcell
 * 
 * This class Models the MainCategorySelection page of the User Interface. It navigates the user to 1 of 4 selection screens depending on their input.
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is the click event for the entree button and navigates the user to the entree selection menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void EntreeClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// This method is the click event for the combo button and navigates the user to the combo selection menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ComboClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// This method is the click event for the drink button and navigates the user to the drink selection menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DrinkClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// This method is the click event for the side button and navigates the user to the side selection menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SideClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
