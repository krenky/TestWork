using System.Reflection.Metadata;

namespace TestWork
{
    public class Triangle : Figure
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide + secondSide)
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
            else
            {
                throw new ArgumentException("Невозможные стороны треугольника");
            }
        }

        public double FirstSide { get => firstSide; 
            set 
            {
                firstSide = value > 0 ? value : throw new ArgumentException("Сторона не может быть равна или меньше 0");
            }
        }
        public double SecondSide { get => secondSide;
            set
            {
                secondSide = value > 0 ? value : throw new ArgumentException("Сторона не может быть равна или меньше 0");
            }
        }
        public double ThirdSide { get => thirdSide;
            set
            {
                thirdSide = value > 0 ? value : throw new ArgumentException("Сторона не может быть равна или меньше 0");
            }
        }
        public override double CalculateArea()
        {
            if (IsRightTriangle())
                return CalculateAreaRightTriangle();
            else
            {
                double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
            }
        }
        private double CalculateAreaRightTriangle()
        {
            switch (GetLargestSide())
            {
                case "FirstSide":
                    {
                        return SecondSide * ThirdSide / 2;
                    }
                case "SecondSide":
                    {
                        return FirstSide * ThirdSide / 2;
                    }
                case "ThirdSide":
                    {
                        return FirstSide * SecondSide / 2;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
        private string GetLargestSide()
        {
            if (FirstSide < SecondSide)
            {
                if (SecondSide < ThirdSide)
                    return "ThirdSide";
                else
                    return "SecondSide";
            }
            else
            {
                if (FirstSide < ThirdSide)
                    return "ThirdSide";
                else
                    return "FirstSide";
            }
        }
        private double GetSumSquaresLegs(double firstLeg, double secondLeg)
        {
            return Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2);
        }
        public bool IsRightTriangle()
        {
            switch (GetLargestSide())
            {
                case "FirstSide":
                    {
                        return Math.Pow(FirstSide, 2) == GetSumSquaresLegs(SecondSide, ThirdSide);
                    }
                case "SecondSide":
                    {
                        return Math.Pow(SecondSide, 2) == GetSumSquaresLegs(FirstSide, ThirdSide);
                    }
                case "ThirdSide":
                    {
                        return Math.Pow(ThirdSide, 2) == GetSumSquaresLegs(FirstSide, SecondSide);
                    }
                default:
                    {
                        return false;
                    }
            }
        }
    }
}
