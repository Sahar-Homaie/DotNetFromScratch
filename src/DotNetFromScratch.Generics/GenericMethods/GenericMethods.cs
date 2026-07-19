using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFromScratch.Generics.GenericMethods
{
    public class GenericMethods
    {
        public void PrintValue<T>(T value)
        {
            Console.WriteLine($"value:{value}");
        }

        public void PrintTwoValues<T1, T2>(T1 first, T2 second)
        {
            Console.WriteLine($"first one is {first} and second one is {second}");
        }

        public void Log<T>(T log) { }

        public void Swap<TInput> (ref TInput first, ref TInput second)
        {
            TInput temp = first;
            first = second;
            second = temp;
        }
    }
}
