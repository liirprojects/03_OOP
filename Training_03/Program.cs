namespace Training_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list_transport = new List<Vehicle>()
            {
               new Car(), new Bicycle()
            };

            foreach (var vehicle in list_transport)
            {
                vehicle.Move();
            }
            Vehicle vehicle1 = new Car();
            Car car = (Car)vehicle1;
            car.Move();

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        private double speed;
        public double Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 || value > 280)
                    throw new ArgumentOutOfRangeException("Speed has a limit range");
                speed = value;
            }
        }

        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (capacity < 1 || capacity > 2000)
                    throw new ArgumentOutOfRangeException("Capasity have to lead the vehicle rules");
                capacity = value;
            }
        }

        public virtual void Move()
        {
            Console.WriteLine("Vehicle is moving..");
        }
    }
    class Car : Vehicle
    {
        private int numberOfDoors;

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set {
                if (numberOfDoors < 2 || numberOfDoors > 10)
                    throw new ArgumentOutOfRangeException("Number of doors were in incorect form");
            }
        }
        public void Honk()
        {
            Console.WriteLine("The car is honking");
        }

        public override void Move()
        {
            Console.WriteLine("Car is moving");
        }

    }
    class Bicycle: Vehicle
    {
        private string type;
        public string Type { get; set; }

        public void RingBell()
        {
            Console.WriteLine("The bikes bell is ringing");
        }
    }
}
