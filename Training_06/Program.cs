namespace Training_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    abstract class Animal
    {
        private double weight;
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Weight is under the invalid limit");

                weight = value;
            }
        }
        private int age;
        protected int Age
        {
            get { return  age; }
            set {
                CheckAge();
                age = value;
            }
        }
        protected void CheckAge()
        {
            if (Age < 0 && Age > 25)
                throw new ArgumentOutOfRangeException("Age can not be negative");
        }


    }
    class Dog
    {

    }
    class Cat
    {

    }
}
