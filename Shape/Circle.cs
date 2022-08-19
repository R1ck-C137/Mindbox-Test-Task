namespace Shape
{
    public class Circle : IShape
    {
        double Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть меньше нуля");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
