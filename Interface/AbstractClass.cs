using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal abstract class AbstractClass
    {
        public abstract void Speak();
        public virtual void Introduce()
        {
            Console.WriteLine("It's an introduction");
        }

        public void Greet()
        {
            Console.WriteLine("Hello! Welcome!");
        }
    }
}
