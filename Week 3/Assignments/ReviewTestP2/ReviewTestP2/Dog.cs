using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTestP2
{
    class Dog : Animal
    {

        public Dog(string _name, int _age) : base(_name, _age)
        {
            Console.WriteLine("Dog Created");
        }

        public override string Speak()
        {
            Console.WriteLine(base.Speak());
            return "Woof woof! My name is " + name;
        }
    }
}
