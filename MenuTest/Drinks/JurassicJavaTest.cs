using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava ft = new JurassicJava();
            Assert.Equal(0.59, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava ft = new JurassicJava();
            Assert.Equal<uint>(2, ft.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava ft = new JurassicJava();
            Assert.Contains<string>("Water", ft.Ingredients);
            Assert.Contains<string>("Coffee", ft.Ingredients);
            Assert.Equal<int>(2, ft.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava ft = new JurassicJava();
            Assert.False(ft.Ice);
        }
        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurassicJava ft = new JurassicJava();
            Assert.False(ft.RoomForCream);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava ft = new JurassicJava();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            JurassicJava ft = new JurassicJava();
            ft.Size = Size.Medium;
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava ft = new JurassicJava();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(4, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava ft = new JurassicJava();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            JurassicJava ft = new JurassicJava();
            ft.Size = Size.Large;
            Assert.Equal(1.49, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava ft = new JurassicJava();
            ft.Size = Size.Large;
            Assert.Equal<uint>(8, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava ft = new JurassicJava();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }
        [Fact]
        public void CheckAddIce()
        {
            JurassicJava ft = new JurassicJava();
            ft.AddIce();
            Assert.True(ft.Ice);
            Assert.Contains("Add Ice", ft.Special);
        }
        [Fact]
        public void CheckLeaveRoomForCream()
        {
            JurassicJava ft = new JurassicJava();
            ft.LeaveRoomForCream();
            Assert.True(ft.RoomForCream);
            Assert.Contains("Add Room For Cream", ft.Special);
        }
    }
}
