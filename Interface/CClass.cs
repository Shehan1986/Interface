using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class CClass: AbstractClass, IInterface, IShape 
    {
        public override void Speak()//override is must in abstract class inhetitance
        { 
        
        }
        public override void Introduce()//override is must in virtual class inhetitance
        {
            Console.WriteLine("It's an introduction");
        }
        public void CalculateArea()
        { 
        
        }
        public void TestMethod2()
        { 
        
        }
        public void TestMethod3()
        {
            Console.WriteLine("CClass TestMethod3");
        }
        //public new void TestMethode()
        //{
        //    Console.WriteLine("This is from Child class");
        //}
    }
}
