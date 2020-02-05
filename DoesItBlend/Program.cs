using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var s = new Strawberry();
            var p = new CellPhone();
            var m = new Mango();
            var c = new IceCubes();

            List<IBlendable> fruits = new List<Fruit>() { b, s, m, c, p };

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.GetType());
                Console.WriteLine(fruit.Blend());
            }
        }
    }
}
