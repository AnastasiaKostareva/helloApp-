using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetBlack();
        }

        static void GreetWhite(string[] args)
        {
            Console.WriteLine("hello white");
        }

        static void GreetBlack(string[] args)
        {
            Console.WriteLine("hello black");
        }
    }
}