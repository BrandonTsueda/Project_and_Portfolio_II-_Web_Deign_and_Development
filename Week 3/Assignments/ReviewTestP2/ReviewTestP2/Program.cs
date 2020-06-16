using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTestP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Fido", 10);
            Console.WriteLine(myDog.Speak());
            Console.WriteLine(myDog.age);
        }
    }
}
