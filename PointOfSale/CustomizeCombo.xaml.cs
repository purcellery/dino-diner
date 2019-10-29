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
 * CustomizeCombo.xaml.cs
 * Braden Purcell
 * 
 * This class Models the CustomizeCombo page of the User Interface. 
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public bool choseSoda = false;
        public bool choseTea = false;
        public bool choseWater = false;
        public bool choseCoffee = false;
        public bool choseSticks = false;
        public bool choseFries = false;
        public bool choseTots = false;
        public bool choseMac = false;

        public CustomizeCombo()
        {
            InitializeComponent();
            DrinkButton.Content = "Select a Drink";
            SideButton.Content = "Select a Side";
            

        }
        public void SideClick(object sender, RoutedEventArgs args)
        {
            SideSelection s = new SideSelection();
            s.fromCombo = true;
            NavigationService.Navigate(s);
        }
        public void DrinkClick(object sender, RoutedEventArgs args)
        {
            DrinkSelection d = new DrinkSelection();
            d.fromCombo = true;
            NavigationService.Navigate(d);
        }
        public void CheckDrink()
        {
            if (choseSoda)
            {
                DrinkButton.Content = "Sodasaurus";
            }
            else if (choseCoffee)
            {
                DrinkButton.Content = "Jurassic Java";
            }
            else if (choseTea)
            {
                DrinkButton.Content = "Tyrannotea";
            }
            else if (choseWater)
            {
                DrinkButton.Content = "Water";
            }
        }

        public void CheckSide()
        {
            if (choseFries)
            {
                SideButton.Content = "Fryceritops";
            }
            else if (choseTots)
            {
                SideButton.Content = "Triceritots";
            }
            else if (choseSticks)
            {
                SideButton.Content = "Mezzorella Sticks";
            }
            else if (choseMac)
            {
                SideButton.Content = "Meteor Mac & Cheese";
            }
        }
    }
}
