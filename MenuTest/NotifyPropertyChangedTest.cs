using System;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;

namespace MenuTest
{
    public class NotifyPropertyChangedTest
    {
        [Fact]
        public void CheckPropertyChangedJurassicJava()
        {
            JurassicJava ft = new JurassicJava();
            Assert.PropertyChanged(ft, "Price", ()=>ft.Price *= 2 );
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
            Assert.PropertyChanged(ft, "Special", () => ft.LeaveRoomForCream());
            Assert.PropertyChanged(ft, "Room For Cream", () => ft.LeaveRoomForCream());
            Assert.PropertyChanged(ft, "Ice", () => ft.AddIce());
        }
        [Fact]
        public void CheckPropertyChangedTyrannotea()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
            Assert.PropertyChanged(ft, "Sweet", () => ft.Sweet = true);
            Assert.PropertyChanged(ft, "Lemon", () => ft.AddLemon());
            Assert.PropertyChanged(ft, "Ice", () => ft.HoldIce()); ;
            Assert.PropertyChanged(ft, "Special", () => ft.AddLemon());
        }
        [Fact]
        public void CheckPropertyChangedSodasaurus()
        {
            Sodasaurus ft = new Sodasaurus();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
            Assert.PropertyChanged(ft, "Flavor", () => ft.Flavor = SodasaurusFlavor.Cherry);
            Assert.PropertyChanged(ft, "Special", () => ft.HoldIce());
            Assert.PropertyChanged(ft, "Ice", () => ft.HoldIce());
        }
        [Fact]
        public void CheckPropertyChangedWater()
        {
            Water ft = new Water();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
            Assert.PropertyChanged(ft, "Lemon", () => ft.AddLemon());
            Assert.PropertyChanged(ft, "Ice", () => ft.HoldIce());
            Assert.PropertyChanged(ft, "Special", () => ft.AddLemon());

        }
        [Fact]
        public void CheckPropertyChangedBrontowurst()
        {
            Brontowurst ft = new Brontowurst();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Bun", () => ft.HoldBun());
            Assert.PropertyChanged(ft, "Onion", () => ft.HoldOnion());
            Assert.PropertyChanged(ft, "Peppers", () => ft.HoldPeppers());
            Assert.PropertyChanged(ft, "Special", () => ft.HoldBun());
        }

        [Fact]
        public void CheckPropertyChangedDinoNuggets()
        {
            DinoNuggets ft = new DinoNuggets();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Special", () => ft.AddNugget());
        }
        [Fact]
        public void CheckPropertyChangedPrehistoricPBJ()
        {
            PrehistoricPBJ ft = new PrehistoricPBJ();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Peanut Butter", () => ft.HoldPeanutButter());
            Assert.PropertyChanged(ft, "Jelly", () => ft.HoldJelly());
            Assert.PropertyChanged(ft, "Special", () => ft.HoldJelly());
        }
        [Fact]
        public void CheckPropertyChangedPterodactylWings()
        {
            PterodactylWings ft = new PterodactylWings();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
        }
        [Fact]
        public void CheckPropertyChangedSteakosaurusBurger()
        {
            SteakosaurusBurger ft = new SteakosaurusBurger();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Bun", () => ft.HoldBun());
            Assert.PropertyChanged(ft, "Pickle", () => ft.HoldPickle());
            Assert.PropertyChanged(ft, "Mustard", () => ft.HoldMustard());
            Assert.PropertyChanged(ft, "Ketchup", () => ft.HoldKetchup());
            Assert.PropertyChanged(ft, "Special", () => ft.HoldBun());
        }
        [Fact]
        public void CheckPropertyChangedTRexKingBurger()
        {
            TRexKingBurger ft = new TRexKingBurger();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Bun", () => ft.HoldBun());
            Assert.PropertyChanged(ft, "Pickle", () => ft.HoldPickle());
            Assert.PropertyChanged(ft, "Mustard", () => ft.HoldMustard());
            Assert.PropertyChanged(ft, "Ketchup", () => ft.HoldKetchup());
            Assert.PropertyChanged(ft, "Mayo", () => ft.HoldMayo());
            Assert.PropertyChanged(ft, "Special", () => ft.HoldBun());
            Assert.PropertyChanged(ft, "Onion", () => ft.HoldOnion());
            Assert.PropertyChanged(ft, "Lettuce", () => ft.HoldLettuce());
        }
        [Fact]
        public void CheckPropertyChangedVelociwrap()
        {
            VelociWrap ft = new VelociWrap();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Lettuce", () => ft.HoldLettuce());
            Assert.PropertyChanged(ft, "Cheese", () => ft.HoldCheese());
            Assert.PropertyChanged(ft, "Dressing", () => ft.HoldDressing());
            Assert.PropertyChanged(ft, "Special", () => ft.HoldDressing());
        }
        [Fact]
        public void CheckPropertyChangedFryceritops()
        {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
        }
        [Fact]
        public void CheckPropertyChangedMeteorMacAndCheese()
        {
            MeteorMacAndCheese ft = new MeteorMacAndCheese();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
        }
        [Fact]
        public void CheckPropertyChangedMezzorellaSticks()
        {
            MezzorellaSticks ft = new MezzorellaSticks();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
        }
        [Fact]
        public void CheckPropertyChangedTriceritots()
        {
            Triceritots ft = new Triceritots();
            Assert.PropertyChanged(ft, "Price", () => ft.Price *= 2);
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Medium);
        }
        [Fact]
        public void CheckPropertyChangedCretaceousCombo()
        {
            VelociWrap v = new VelociWrap();
            DinoNuggets n = new DinoNuggets();
            Triceritots t = new Triceritots();
            JurassicJava j = new JurassicJava();
            CretaceousCombo ft = new CretaceousCombo(v);
            Assert.PropertyChanged(ft, "Side", () => ft.Side = t);
            Assert.PropertyChanged(ft, "Drink", () => ft.Drink = j);
            Assert.PropertyChanged(ft, "Entree", () => ft.Entree = n);
        }
    }
}
