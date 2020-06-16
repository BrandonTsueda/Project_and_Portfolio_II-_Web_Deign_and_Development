using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTestP2
{
    class Animal
    {
        public string name;
        public int age;

        public Animal(string _name, int _age)
        {
            name = _name;
            age = _age;
            Console.WriteLine("Animal created");
            Console.WriteLine("{0}, {1}", name, age);
        }

        public virtual string Speak()
        {
            return "I'm opening my mouth.";
        }
    }
}
