using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water ft = new Water();
            Assert.Equal(0.10, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water ft = new Water();
            Assert.Equal<uint>(0, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water ft = new Water();
            Assert.Contains<string>("Water", ft.Ingredients);
            Assert.Equal<int>(1, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water ft = new Water();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water ft = new Water();
            Assert.True(ft.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water ft = new Water();
            Assert.False(ft.Lemon);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Water ft = new Water();
            ft.Size = Size.Medium;
            Assert.Equal(0.10, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water ft = new Water();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(0, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water ft = new Water();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Water ft = new Water();
            ft.Size = Size.Large;
            Assert.Equal(0.10, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water ft = new Water();
            ft.Size = Size.Large;
            Assert.Equal<uint>(0, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water ft = new Water();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }

        [Fact]
        public void CheckHoldIce()
        {
            Water ft = new Water();
            ft.HoldIce();
            Assert.False(ft.Ice);
        }

        [Fact]
        public void CheckAddLemon()
        {
            Water ft = new Water();
            ft.AddLemon();
            Assert.True(ft.Lemon);
            Assert.Contains("Lemon", ft.Ingredients);
        }
    }
}


