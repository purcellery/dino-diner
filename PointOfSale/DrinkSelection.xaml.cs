using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Size = DinoDiner.Menu.Size;

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


        public bool fromCombo = false;
        public DrinkSelection()
        {
            InitializeComponent();
            addLemonButton.Visibility = Visibility.Collapsed;
            creamButton.Visibility = Visibility.Collapsed;
            decafButton.Visibility = Visibility.Collapsed;
            sweetButton.Visibility = Visibility.Collapsed;
            flavorButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// This method is the click event for the sodasaurus button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SodasaurusClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                

                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.CheckDrink();

                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    {
                        Sodasaurus t = new Sodasaurus();
                        t.Size = combo.Size;
                        combo.Drink = t;
                    }

                }
                else
                {
                    order.Items.Add(new Sodasaurus());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }

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
            if (DataContext is Order order)
            {
                

                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.CheckDrink();

                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    {
                        Tyrannotea t = new Tyrannotea();
                        t.Size = combo.Size;
                        combo.Drink = t;
                    }

                }
                else
                {
                    order.Items.Add(new Tyrannotea());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }

            addLemonButton.Visibility = Visibility.Visible;
            creamButton.Visibility = Visibility.Collapsed;
            decafButton.Visibility = Visibility.Collapsed;
            sweetButton.Visibility = Visibility.Visible;
            flavorButton.Visibility = Visibility.Collapsed;

            /*if (fromCombo) {
                CustomizeCombo c = new CustomizeCombo();
                c.choseTea = true;
                c.choseWater = false;
                c.choseSoda = false;
                c.choseCoffee = false;
                c.CheckDrink();
                NavigationService.Navigate(c); 
            }*/

        }
        /// <summary>
        /// This method is the click event for the Jurassic Java button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void JurassicJavaClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                

                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.CheckDrink();

                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    {
                        JurassicJava t = new JurassicJava();
                        t.Size = combo.Size;
                        combo.Drink = t;
                    }

                }
                else
                {
                    order.Items.Add(new JurassicJava());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }

            addLemonButton.Visibility = Visibility.Collapsed;
            creamButton.Visibility = Visibility.Visible;
            decafButton.Visibility = Visibility.Visible;
            sweetButton.Visibility = Visibility.Collapsed;
            flavorButton.Visibility = Visibility.Collapsed;

            /*if (fromCombo)
            {
                CustomizeCombo c = new CustomizeCombo();
                c.choseTea = false;
                c.choseWater = false;
                c.choseSoda = false;
                c.choseCoffee = true;
                c.CheckDrink();
                NavigationService.Navigate(c);
            }*/
        }
        /// <summary>
        /// This method is the click event for the water button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void WaterClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Water());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                if (fromCombo)
                {
                    CustomizeCombo c = new CustomizeCombo();
                    c.CheckDrink();

                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                    {
                        Water t = new Water();
                        t.Size = combo.Size;
                        combo.Drink = t;
                    }

                }
                else
                {
                    order.Items.Add(new Water());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }

            addLemonButton.Visibility = Visibility.Visible;
            creamButton.Visibility = Visibility.Collapsed;
            decafButton.Visibility = Visibility.Collapsed;
            sweetButton.Visibility = Visibility.Collapsed;
            flavorButton.Visibility = Visibility.Collapsed;

            /*if (fromCombo)
            {
                CustomizeCombo c = new CustomizeCombo();
                c.choseTea = false;
                c.choseWater = true;
                c.choseSoda = false;
                c.choseCoffee = false;
                c.CheckDrink();
                NavigationService.Navigate(c);
            }*/
        }

        /// <summary>
        /// This method is the click event for the flavor button and adjusts buttons and bool values accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void FlavorClick(object sender, RoutedEventArgs args)
        {
               NavigationService.Navigate(new FlavorSelection());
        }

        public void ToggleIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (!drink.Ice)
                    {
                        drink.AddIce();
                    }
                    else
                    {
                        drink.HoldIce();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (!combo.Drink.Ice)
                    {
                        combo.Drink.AddIce();
                    }
                    else
                    {
                        combo.Drink.HoldIce();
                    }
                }
            }
        }

        public void ToggleDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    if (!java.Decaf)
                    {
                        java.MakeDecaf();
                    }
                    else
                    {
                        java.MakeCaf();
                    }
                }else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava java1)
                    {
                        if (!java1.Decaf)
                        {
                            java1.MakeDecaf();
                        }
                        else
                        {
                            java1.MakeCaf();
                        }
                    }
                    
                }
            }
        }

        public void ToggleSize(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if(sender == SmallButton)
                    {
                        drink.Size = Size.Small;
                    }
                    else if(sender == MediumButton)
                    {
                        drink.Size = Size.Medium;
                    }
                    else
                    {
                        drink.Size = Size.Large;
                    }

                }else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (sender == SmallButton)
                    {
                        combo.Drink.Size = Size.Small;
                    }
                    else if (sender == MediumButton)
                    {
                        combo.Drink.Size = Size.Medium;
                    }
                    else
                    {
                        combo.Drink.Size = Size.Large;
                    }

                }
            }
        }

        public void ToggleSweet(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    if (!tea.Sweet)
                    {
                        tea.Sweet = true;
                    }
                    else
                    {
                        tea.Sweet = false;
                    }
                }else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is Tyrannotea tea1)
                    {
                        if (!tea1.Sweet)
                        {
                            tea1.Sweet = true;
                        }
                        else
                        {
                            tea1.Sweet = false;
                        }
                    }
                    
                }
                
            }
        }

        public void ToggleLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    if (!water.Lemon)
                    {
                        water.AddLemon();
                    }
                    else
                    {
                        water.NoLemon();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    if (!tea.Lemon)
                    {
                        tea.AddLemon();
                    }
                    else
                    {
                        tea.NoLemon();
                    }
                }else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is Water water1)
                    {
                        if (!water1.Lemon)
                        {
                            water1.AddLemon();
                        }
                        else
                        {
                            water1.NoLemon();
                        }
                    }
                    else if (combo.Drink is Tyrannotea tea1)
                    {
                        if (!tea1.Lemon)
                        {
                            tea1.AddLemon();
                        }
                        else
                        {
                            tea1.NoLemon();
                        }
                    }
                }
            }
        }

        public void ToggleCream(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    if (!java.RoomForCream)
                    {
                        java.LeaveRoomForCream();
                    }
                    else
                    {
                        java.NoRoomForCream();
                    }
                }else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava java1)
                    {
                        if (!java1.RoomForCream)
                        {
                            java1.LeaveRoomForCream();
                        }
                        else
                        {
                            java1.NoRoomForCream();
                        }
                    }
                }
            }
        }

        public void DoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
