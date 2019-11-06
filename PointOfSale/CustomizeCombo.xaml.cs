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
using DinoDiner.Menu;

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
            DrinkButton.Content = "Edit Drink";
            SideButton.Content = "Edit Side";
        }

        public void SmallClick(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com)
                {
                    com.Size = DinoDiner.Menu.Size.Small;
                    com.Side.Size = DinoDiner.Menu.Size.Small;
                    com.Drink.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        public void MediumClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com)
                {
                    com.Size = DinoDiner.Menu.Size.Medium;
                    com.Side.Size = DinoDiner.Menu.Size.Medium;
                    com.Drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        public void LargeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com)
                {
                    com.Size = DinoDiner.Menu.Size.Large;
                    com.Side.Size = DinoDiner.Menu.Size.Large;
                    com.Drink.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        public void EntreeClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com)
                {
                    CustomizeEntree e = new CustomizeEntree();
                    e.LoadButtonsAndContent(com.Entree);
                    NavigationService.Navigate(e);
                }
            }
        }

        public void SideClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com)
                {
                    SideSelection s = new SideSelection();
                    s.fromCombo = true;
                    NavigationService.Navigate(s);
                }
            }
            
        }
        public void DrinkClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com)
                {
                    DrinkSelection s = new DrinkSelection();
                    s.fromCombo = true;
                    NavigationService.Navigate(s);
                }
            }
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
