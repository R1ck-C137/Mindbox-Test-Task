
namespace Shape
{
    /// <summary>
    /// Статический класс, для вычисления площадей без объявления фигуры
    /// </summary>
    public static class ShapeUtilits
    {
        public static double GetTriangleAreaBySides(double a, double b, double c)
        {
            return new Triangle(a, b, c).GetArea();
        }

        public static double GetCircleArea(double radius)
        {
            return new Circle(radius).GetArea();
        }
    }
}
