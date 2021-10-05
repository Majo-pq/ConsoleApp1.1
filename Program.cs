using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ukelele uke = new Ukelele("cafe", "soprano");

            Console.WriteLine(uke.ToString());
        }
    }
}
