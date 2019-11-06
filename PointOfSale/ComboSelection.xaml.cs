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
 * ComboSelection.xaml.cs
 * Braden Purcell
 * 
 * This class Models the ConboSelection page of the User Interface. It navigates the user to the ComboCustomization page after they select a combo.
 */

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is the click event for when the user clicks on a combo that navigates them to the combo customization page afterward.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree e = new Brontowurst();
                CustomizeCombo c = new CustomizeCombo();
                if (sender == BratButton)
                {
                    e = new Brontowurst();
                }
                else if(sender == NuggetButton)
                {
                    e = new DinoNuggets();
                }
                else if (sender == SteakButton)
                {
                    e = new SteakosaurusBurger();
                }
                else if (sender == TRexButton)
                {
                    e = new TRexKingBurger();
                }
                else if (sender == WrapButton)
                {
                    e = new VelociWrap();
                }
                else if (sender == WingButton)
                {
                    e = new PterodactylWings();
                }
                else if (sender == PBJButton)
                {
                    e = new PrehistoricPBJ();
                }
                order.Add(new CretaceousCombo(e));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                //c.SetCombo(CretaceousCombo)order.Items.Last<IOrderItem>());
                NavigationService.Navigate(c);
            }
        }
    }
}
