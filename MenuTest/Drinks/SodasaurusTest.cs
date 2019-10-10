using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus ft = new Sodasaurus();
            Assert.Equal(1.50, ft.Price, 2);
        }
        [Fact]
        public void CheckAddFlavor()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, ft.Flavor);
            ft.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, ft.Flavor);
            ft.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, ft.Flavor);
            ft.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, ft.Flavor);
            ft.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, ft.Flavor);
            ft.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, ft.Flavor);
            ft.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, ft.Flavor);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus ft = new Sodasaurus();
            Assert.Equal<uint>(112, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus ft = new Sodasaurus();
            Assert.Contains<string>("Water", ft.Ingredients);
            Assert.Contains<string>("Natural Flavors", ft.Ingredients);
            Assert.Contains<string>("Cane Sugar", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus ft = new Sodasaurus();
            Assert.True(ft.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus ft = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Size = Size.Medium;
            Assert.Equal(2.00, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(156, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Size = Size.Large;
            Assert.Equal(2.50, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Size = Size.Large;
            Assert.Equal<uint>(208, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }
        [Fact]
        public void CheckHoldIce()
        {
            Sodasaurus ft = new Sodasaurus();
            ft.HoldIce();
            Assert.False(ft.Ice);
        }
    }
}
