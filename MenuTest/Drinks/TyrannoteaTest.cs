using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.Equal<uint>(8, ft.Calories);
        }
        [Fact]
        public void CheckDefaultLemon()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.False(ft.Lemon);
        }

        [Fact]
        public void CheckDefaultSweetener()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.False(ft.Lemon);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.Contains<string>("Water", ft.Ingredients);
            Assert.Contains<string>("Tea", ft.Ingredients);
            Assert.Equal<int>(2, ft.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.True(ft.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea ft = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Size = Size.Medium;
            Assert.Equal(1.49, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(16, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Size = Size.Large;
            Assert.Equal(1.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Size = Size.Large;
            Assert.Equal<uint>(32, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }
        [Fact]
        public void CheckHoldIce()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.HoldIce();
            Assert.False(ft.Ice);
        }
        [Fact]
        public void CheckAddLemon()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Lemon = false;
            ft.AddLemon();
            Assert.True(ft.Lemon);
            Assert.Contains<string>("Lemon", ft.Ingredients);
        }
        [Fact]
        public void CheckSweetCaloriesAndIngredients()
        {
            Tyrannotea ft = new Tyrannotea();
            ft.Sweet = true;
            Assert.Contains("Cane Sugar", ft.Ingredients);

            Assert.Equal<uint>(16, ft.Calories);
            ft.Size = Size.Medium;
            ft.Sweet = true;
            Assert.Equal<uint>(32, ft.Calories);
            ft.Size = Size.Large;
            ft.Sweet = true;
            Assert.Equal<uint>(64, ft.Calories);

            ft.Sweet = false;
            Assert.Equal<uint>(32, ft.Calories);
            ft.Size = Size.Medium;
            ft.Sweet = false;
            Assert.Equal<uint>(16, ft.Calories);
            ft.Size = Size.Small;
            ft.Sweet = false;
            Assert.Equal<uint>(8, ft.Calories);
        }
    }
}
