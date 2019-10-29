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
using Size = DinoDiner.Menu.Size;

/**
 * SideSelection.xaml.cs
 * Braden Purcell
 * 
 * This class Models the SideSelection page of the User Interface.
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public bool fromCombo = false;
        public SideSelection()
        {
            InitializeComponent();
            if (fromCombo)
            {
                LargeButton.Visibility = Visibility.Collapsed;
                SmallButton.Visibility = Visibility.Collapsed;
                MediumButton.Visibility = Visibility.Collapsed;
            }
        }

        public void FryClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order) {
                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.choseFries = true;
                    c.choseTots = false;
                    c.choseSticks = false;
                    c.choseMac = false;
                    c.CheckSide();
                    NavigationService.Navigate(c);
                }
                order.Items.Add(new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void TotClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.choseFries = false;
                    c.choseTots = true;
                    c.choseSticks = false;
                    c.choseMac = false;
                    c.CheckSide();
                    NavigationService.Navigate(c);
                }
                order.Items.Add(new Fryceritops());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void MezzStickClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.choseFries = false;
                    c.choseTots = false;
                    c.choseSticks = true;
                    c.choseMac = false;
                    c.CheckSide();
                    NavigationService.Navigate(c);
                }
                order.Items.Add(new MezzorellaSticks());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void MacClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.choseFries = false;
                    c.choseTots = false;
                    c.choseSticks = false;
                    c.choseMac = true;
                    c.CheckSide();
                    NavigationService.Navigate(c);
                }
                order.Items.Add(new MeteorMacAndCheese());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void ToggleSize(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    if (sender == SmallButton)
                    {
                        side.Size = Size.Small;
                    }
                    else if (sender == MediumButton)
                    {
                        side.Size = Size.Medium;
                    }
                    else
                    {
                        side.Size = Size.Large;
                    }

                }
            }
        }
    }
}
