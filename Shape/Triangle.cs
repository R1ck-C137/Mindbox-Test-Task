
namespace Shape
{
    public class Triangle : IShape
    {
        double[] SideLengths;

        public bool IsRight
        {
            get
            {
                //Сортируем для вычисление самой длинной стороны
                Array.Sort(SideLengths);
                //В прямоуггольном треугольнике квадрат гипотенузы равен сумме квадратов катетов
                return Math.Pow(SideLengths[0], 2) + Math.Pow(SideLengths[1], 2) == Math.Pow(SideLengths[2], 2);
            }
        }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Сторона треугольника не может быть меньше нуля");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new Exception("Сторона треугольника не может быть больше суммы двух других сторон");
            }
            SideLengths = new double[3] { a, b, c };
        }

        public double GetArea()
        {
            //Зная длинну трёх сторон треугольника, для нашего случая отлична подходит формула Герона 
            double p = SideLengths.Sum() / 2;
            return Math.Sqrt(p * (p - SideLengths[0]) * (p - SideLengths[1]) * (p - SideLengths[2]));
        }
    }
}
