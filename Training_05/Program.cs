namespace Training_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            DrivingMethod(car);

            Console.ReadKey();
        }
        static void DrivingMethod(IDrivable drivable)
        {
            drivable.Drive();
        }
    }
    interface IDrivable
    {
        void Drive();
    }
    class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("This is method for driving a car");
        }
    }
    class Bicycle : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("This is method for driving a bicycle");
        }
    }
}
