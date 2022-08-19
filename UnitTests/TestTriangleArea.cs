using Shape;
using System;
using Xunit;

namespace UnitTests
{
    public class TestTriangleArea
    {

        [Fact]
        public void IsTriangleAreaCorrect()
        {
            Assert.Equal(6.0, ShapeUtilits.GetTriangleAreaBySides(3, 4, 5));
            Assert.Equal(3.897114317029974, ShapeUtilits.GetTriangleAreaBySides(3, 3, 3));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(0, 1, 1));
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(1, 0, 1));
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(1, 1, 0));

            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(-1, 1, 1));
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(1, -1, 1));
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(1, 1, -1));

            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(1, 2, 4));
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(4, 1, 2));
            Assert.Throws<Exception>(() => ShapeUtilits.GetTriangleAreaBySides(2, 4, 1));
        }

        [Fact]
        public void IsRight_Correct()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight);
            Assert.False(new Triangle(3, 3, 3).IsRight);
        }

    }
}
