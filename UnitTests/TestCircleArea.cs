using Shape;

namespace UnitTests
{
    public class TestCircleArea
    {
        [Fact]
        public void IsCircleAreaCorrect()
        {
            Assert.Equal(Math.PI, ShapeUtilits.GetCircleArea(1));
            Assert.Equal(Math.PI * 4, ShapeUtilits.GetCircleArea(2));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<Exception>(() => ShapeUtilits.GetCircleArea(0));
            Assert.Throws<Exception>(() => ShapeUtilits.GetCircleArea(-1));
        }
    }
}