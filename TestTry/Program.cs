using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTry
{
    public interface IFly
    {
        void Fly();
    }
    public class Duck
    {
        public void MakeSound()
        {
            Console.WriteLine("I can make sound");
        }
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }

    public class MallrdDuck : Duck, IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }

    public class DecoyDuck : Duck
    {

    }

    public class ToyDuck : Duck
    {

    }
    class Program
    {

        static void Main(string[] args)
        {
            //Duck obj = new DecoyDuck();
            //obj.Fly();
            ICanFly(new MallrdDuck());
            List<string> nameCollection = new List<string>() { "John wick","steve rogers","hulk"};
            ReadOnlyCollection<string> readOnlyColl = new ReadOnlyCollection<string>(new List<string> { "a","b","c"});
            var result = from name in nameCollection
                         where name.Equals("John wick")
                         select name;

            Add(readOnlyColl);
            Console.ReadKey();
        }

        private static void Add(ICollection<string> coll)
        {
            coll.Add("rishu");
        }

        private static void ICanFly(IFly flyingDuck)
        {
            flyingDuck.Fly();
            
        }
    }
}
