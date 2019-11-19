using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {

        public List<IMenuItem> AvailableMenuItems {
            get
            {
                return new List<IMenuItem>() {
                    new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new PterodactylWings()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap()),

                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water(),

                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),

                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }

        public List<Drink> AvailableDrinks
        {
            get
            {
                return new List<Drink>
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        public List<Side> AvailableSides { 
            get
            {
                return new List<Side>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }

        public List<Entree> AvailableEntrees { get
            {
                return new List<Entree>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
            }
        }
        public List<CretaceousCombo> AvailableCombos { 
            get
            {
                return new List<CretaceousCombo>
                {
                    new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new PterodactylWings()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap())
                };
            }
        }

        public string toString()
        {
            string st = "";
            foreach(IMenuItem s in AvailableMenuItems)
            {
                st += s.ToString() + "\n";
            }
            return st;
        }
    }
}
