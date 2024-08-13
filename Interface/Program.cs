using static System.Console;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            PClass pClass = new PClass();
            pClass.TestMethode();

            CClass cClass = new CClass();
            cClass.TestMethode();

            CClass cClass2 = new CClass();
            cClass2.TestMethod3();

           // IInterface  interface = new IInterface();
           // AbstractClass  abstractClass = new AbstractClass();


            ReadKey();
        }
    }
}
