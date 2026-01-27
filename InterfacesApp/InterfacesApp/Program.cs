namespace InterfacesApp
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic sound");
        }
    }

    class Dog() : Animal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Dog ate {food}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }

    class Cat() : Animal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Cat ate {food}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
        }
    }
}
