using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DependencyInjectionApp
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);

    }
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }
    public class Builder: IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;

        //// Setter dependecy injection
        //public Hammer Hammer { get; set; }
        //public Saw Saw { get; set; }

        //private Hammer _hammer;
        //private Saw _saw;

        //// Constructor dependecy injection
        //public Builder(Hammer hammer, Saw saw)
        //{
        //    // Constructor dependecy injection
        //    //_hammer = hammer;
        //    //_saw = saw;
        //}



        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.SetSaw( saw );
            builder.SetHammer( hammer );
            builder.BuildHouse(); 
            Console.ReadKey();

        }
    }
}
