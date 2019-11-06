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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        public CustomizeEntree()
        {
            InitializeComponent();

        }

        public void ClickEvent(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree entree)
                {

                    if (entree is Brontowurst actuallyJustAHotDog)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustAHotDog.SwitchBoolByID(id);
                    }
                    else if (entree is DinoNuggets actuallyJustAPlateOfChickenNuggets)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustAPlateOfChickenNuggets.SwitchBoolByID(id);
                    }
                    else if (entree is PrehistoricPBJ actuallyJustASandwich)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustASandwich.SwitchBoolByID(id);
                    }
                    else if (entree is PterodactylWings actuallyJustAPlateOfChickenWings)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustAPlateOfChickenWings.SwitchBoolByID(id);
                    }
                    else if (entree is SteakosaurusBurger actuallyJustARegularHamBurger)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustARegularHamBurger.SwitchBoolByID(id);
                    }
                    else if (entree is TRexKingBurger actuallyJustABiggerHamBurger)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustABiggerHamBurger.SwitchBoolByID(id);
                    }
                    else if (entree is VelociWrap actuallyJustARolledUpSandwich)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustARolledUpSandwich.SwitchBoolByID(id);
                    }

                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst actuallyJustAHotDog)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustAHotDog.SwitchBoolByID(id);
                    }
                    else if (combo.Entree is DinoNuggets actuallyJustAPlateOfChickenNuggets)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustAPlateOfChickenNuggets.SwitchBoolByID(id);
                    }
                    else if (combo.Entree is PrehistoricPBJ actuallyJustASandwich)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustASandwich.SwitchBoolByID(id);
                    }
                    else if (combo.Entree is PterodactylWings actuallyJustAPlateOfChickenWings)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustAPlateOfChickenWings.SwitchBoolByID(id);
                    }
                    else if (combo.Entree is SteakosaurusBurger actuallyJustARegularHamBurger)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustARegularHamBurger.SwitchBoolByID(id);
                    }
                    else if (combo.Entree is TRexKingBurger actuallyJustABiggerHamBurger)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustABiggerHamBurger.SwitchBoolByID(id);
                    }
                    else if (combo.Entree is VelociWrap actuallyJustARolledUpSandwich)
                    {
                        string s = (sender as Button).Name;
                        s = s[1].ToString();
                        int id = Convert.ToInt32(s);
                        actuallyJustARolledUpSandwich.SwitchBoolByID(id);
                    }
                }
            }
        }

        public void DoneClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void LoadButtonsAndContent(Entree e)
        {
            b1.Visibility = Visibility.Collapsed;
            b2.Visibility = Visibility.Collapsed;
            b3.Visibility = Visibility.Collapsed;
            b4.Visibility = Visibility.Collapsed;
            b5.Visibility = Visibility.Collapsed;
            b6.Visibility = Visibility.Collapsed;
            b7.Visibility = Visibility.Collapsed;
            b8.Visibility = Visibility.Collapsed;

            if (e is Brontowurst)
            {
                b1.Visibility = Visibility.Visible;
                b2.Visibility = Visibility.Visible;
                b3.Visibility = Visibility.Visible;
                b1.Content = "Bun";
                b2.Content = "Onion";
                b3.Content = "Peppers";

            }
            else if (e is SteakosaurusBurger)
            {
                b1.Visibility = Visibility.Visible;
                b3.Visibility = Visibility.Visible;
                b4.Visibility = Visibility.Visible;
                b5.Visibility = Visibility.Visible;
                b1.Content = "Bun";
                b3.Content = "Pickle";
                b4.Content = "Ketchup";
                b5.Content = "Mustard";
            }
            else if (e is VelociWrap)
            {
                b1.Visibility = Visibility.Visible;
                b2.Visibility = Visibility.Visible;
                b3.Visibility = Visibility.Visible;
                b1.Content = "Dressing";
                b2.Content = "Cheese";
                b3.Content = "Lettuce";
            }
            else if (e is DinoNuggets)
            {
                b1.Visibility = Visibility.Visible;
                b2.Visibility = Visibility.Visible;
                b1.Content = "Add Nuggets";
                b2.Content = "Remove Nuggets";
            }
            else if (e is PrehistoricPBJ)
            {
                b1.Visibility = Visibility.Visible;
                b2.Visibility = Visibility.Visible;
                b1.Content = "Peanut Butter";
                b2.Content = "Jelly";
            }
            else if (e is TRexKingBurger)
            {
                b1.Visibility = Visibility.Visible;
                b2.Visibility = Visibility.Visible;
                b3.Visibility = Visibility.Visible;
                b4.Visibility = Visibility.Visible;
                b5.Visibility = Visibility.Visible;
                b6.Visibility = Visibility.Visible;
                b7.Visibility = Visibility.Visible;
                b8.Visibility = Visibility.Visible;
                b1.Content = "Bun";
                b2.Content = "Onion";
                b3.Content = "Pickle";
                b4.Content = "Ketchup";
                b5.Content = "Mustard";
                b6.Content = "Mayo";
                b7.Content = "Tomato";
                b8.Content = "Lettuce";
            }
        }
    }

}
