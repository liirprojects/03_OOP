using System.Linq.Expressions;

namespace Training_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> alimalsList = new List<Animal>
            {
                new Cat(), new Dog()
            };
            AnimalSpeaking(alimalsList);


            Animal animal = new Cat();
            Cat cat = (Cat)animal;
            cat.Speak();
            Console.ReadKey();
        }
        static void AnimalSpeaking(List<Animal> alimalsList)
        {
            foreach (var animal in alimalsList)
            {
                animal.Speak();
            }
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking..");
        }
    }
    class Cat :Animal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Meow");
        }

        public void Hello() { }
    }
    class Dog :Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
