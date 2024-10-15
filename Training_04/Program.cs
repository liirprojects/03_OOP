namespace Training_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle_shape = new Circle(10);

            double area_output = circle_shape.CalculateArea();

            Console.WriteLine("Area of a {0}: {1} cm",circle_shape.ShapeName,area_output);

            Console.ReadKey();
        }
    }
    abstract class Shape
    {
        public abstract string ShapeName { get; protected set; }
        protected double radius { get; set; }
        public const double PiNumber = 3.141;

        public abstract double CalculateArea();

        public void ValidateShapeName(string given_shape)
        {
            if (string.IsNullOrEmpty(given_shape))
                throw new ArgumentException("Shape name cannot be null or empty.");
        }

    }
    class Circle : Shape
    { 
        public Circle(double d)
        {
            if (d > 0)
                this.diameter = d;
            else
                throw new ArithmeticException("The value of a diameter can not be negative");

            this.radius = CalculateRadius();

            shapeName = "Circle";
        }
        private string shapeName;
        public override string ShapeName
        {
            get => shapeName;
            protected set {
                base.ValidateShapeName(value);
                shapeName = value;
            }
        }
        private double diameter;

        private double CalculateRadius()
        {
            double output_value = diameter / 2;

            Console.WriteLine("Based on input diameter value the value of the radius is : [{0} cm]", output_value);
            return output_value;
        }
        public override double CalculateArea()
        {
            double circle_area = PiNumber * Math.Pow(radius, 2);

            return circle_area;
        }
    }
    class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle()
        {
            shapeName = "Rectangle";
        }

        private void CheckValue(double inputValue)
        {
            if (inputValue < 0)
                throw new ArgumentException("The sides of a rectangle cannot be negative");
        }

        private string shapeName;
        public override string ShapeName
        {
            get => shapeName;
            protected set {
                base.ValidateShapeName(value);
                shapeName = value;
            } 
        }

        public override double CalculateArea()
        {
            return height * width;
        }
    } 
}
