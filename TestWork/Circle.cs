

namespace TestWork
{
    public class Circle : Figure
    {
        private double lengthCircle;
        private double radiusCircle;
        private double diameterCircle;

        public Circle(double lengthCircle, double radiusCircle)
        {
            if (lengthCircle > 0 && radiusCircle > 0 && Math.Round(lengthCircle) == Math.Round(2 * radiusCircle * Math.PI))
            {
                LengthCircle = lengthCircle;
                RadiusCircle = radiusCircle;
                DiameterCircle = radiusCircle * 2;
            }
        }

        public double LengthCircle
        {
            get
            {
                return lengthCircle;
            }
            set
            {
                lengthCircle = value > 0 ? value : throw new ArgumentException("Длина не может быть равна или меньше 0");
            }
        }
        public double RadiusCircle
        {
            get
            {
                return radiusCircle;
            }
            set
            {
                radiusCircle = value > 0 ? value : throw new ArgumentException("Радиус не может быть равна или меньше 0");
            }
        }
        public double DiameterCircle
        {
            get
            {
                return diameterCircle;
            }
            set
            {
                diameterCircle = value > 0 ? value : throw new ArgumentException("Диаметр не может быть равна или меньше 0");
            }
        }
        public static double CalculateArea(Figure figure)
        {
            return figure.CalculateArea();
        }
        public override double CalculateArea()
        {
            try
            {
                switch (GetNameFirstFieldNotNull())
                {
                    case "LengthCircle":
                        {
                            return CalculateAreaByUsingLength();
                        }
                    case "RadiusCircle":
                        {
                            return CalculateAreaByUsingRadius();
                        }
                    case "DiameterCircle":
                        {
                            return CalculateAreaByUsingDiameter();
                        }
                    default:
                        {
                            return 0;
                        }
                }
            }
            catch
            {
                throw;
            }

        }
        public double CalculateAreaByUsingLength()
        {
            return Math.Pow(LengthCircle, 2) / (4 * Math.PI);
        }
        public double CalculateAreaByUsingLength(Circle circle)
        {
            return circle.CalculateAreaByUsingLength();
        }
        public double CalculateAreaByUsingRadius()
        {
            return Math.PI * Math.Pow(RadiusCircle, 2);
        }
        public double CalculateAreaByUsingRadius(Circle circle)
        {
            return circle.CalculateAreaByUsingRadius();
        }
        public double CalculateAreaByUsingDiameter()
        {
            return Math.Pow(DiameterCircle, 2) / 4 * Math.PI;
        }
        public double CalculateAreaByUsingDiameter(Circle circle)
        {
            return circle.CalculateAreaByUsingDiameter();
        }

        private string GetNameFirstFieldNotNull()
        {
            if (LengthCircle != null && LengthCircle > 0)
                return nameof(LengthCircle);
            if (RadiusCircle != null && RadiusCircle > 0)
                return nameof(RadiusCircle);
            if (DiameterCircle != null && DiameterCircle > 0)
                return nameof(DiameterCircle);
            throw new Exception("Неверно заданы параметры фигуры");
        }
    }
}
