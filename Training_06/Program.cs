using System.Data.Common;

namespace Training_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dog dog = new Dog();
           dog.Eat(5, 15);

            Animal animal = new Dog();
            if(animal is Dog)
            {
                animal.Make_Sound();
            }

            Console.ReadKey();
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
            get { return age; }
            set {
                if (Age < 0 && Age > 25)
                    throw new ArgumentOutOfRangeException("Age can not be negative");
                age = value;
            }
        }
        public const int max_value = 100;
        private int health_condition;
        public int HealthCondition {
            protected get => health_condition;
            set => value = value < max_value ? health_condition : throw new
                ArgumentOutOfRangeException("Health can not be out of avaliable range");
        }

        private int energy_level;
        public int Energy_level
        {
            protected get => energy_level;
            set => value = value < max_value ? energy_level : throw new
                ArgumentOutOfRangeException("Energy can not be out of avaliable range");
        }

        public abstract void Make_Sound();
        public void Eat(int food_amount, int process_food_time)
        {
            Console.WriteLine("WEIGHT: {0}.\nLEVEL OF ENERGY: {1}",
               weight, energy_level);

            if (energy_level == max_value) {
                Console.WriteLine("ALERT! Eating is not avaliable with the maximum energy");
                return;
            }

            // Counting the energy increase
            int process_speed = 
                process_food_time > 10 && process_food_time < 30 ? process_speed = 2 :
                process_food_time > 30 ? process_speed = 3 :
                throw new Exception("Food process time is incorect.");
            
            energy_level = energy_level + (food_amount / process_speed);

            // Counting the weight depending on the food amount
            weight = weight + food_amount * 0.1;
            
            // If energy level after eating is bigger than max value - its own value will be the same
            if (energy_level >= max_value) energy_level = max_value;

            Console.WriteLine("WEIGHT: {0}.\nLEVEL OF ENERGY: {1}",
               weight, energy_level);
        }

        public void Exercise(double run_km)
        {
            if(health_condition < 10 || energy_level < 10) {

                Console.WriteLine("Health or energy level is low. Ear and Sleep first.");
                return;
            }

            health_condition = health_condition + (int)(run_km + 10);

            // Energy level according to the exercises
            int new_energy = energy_level + (int)(energy_level * run_km) / 100;
            int lower_energy = energy_level - (int)(energy_level * run_km) / 100;

            energy_level = energy_level < new_energy && energy_level > 10 ? energy_level = new_energy :
                           energy_level > new_energy ? energy_level = lower_energy :
                           throw new Exception();
        }
 }
    class Dog : Animal
    {
        public override void Make_Sound()
        {
            int barklevel = 0;
            if (base.HealthCondition > 50 && base.Energy_level > 50)
                barklevel = 70;
            else if (base.HealthCondition < 30 && base.Energy_level < 20)
                barklevel = 40;
            else
                barklevel = 45;

            Console.WriteLine("The Dod is barking on the level {0}", barklevel);
        }
    }
}
