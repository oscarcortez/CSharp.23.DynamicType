using System;

namespace ConsoleApp4DynamicType
{
    class Program
    {
        /// <summary>
        ///  dynamic type
        /// puedes asignar cualquier valor de forma dinamica
        /// se determina su tipo en tiempo de ejecucion, y no en tiempo de compilacion como los typos estatt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            dynamic var1 = 1;
            Console.WriteLine($"{var1}: {var1.GetType().ToString()}");
            
            var1 = "hola";
            Console.WriteLine($"{var1}: {var1.GetType().ToString()}");

            var1 = 12.12;
            Console.WriteLine($"{var1}: {var1.GetType().ToString()}");

            var1 = 12.12f;
            Console.WriteLine($"{var1}: {var1.GetType().ToString()}");

            var1 = 12.12d;
            Console.WriteLine($"{var1}: {var1.GetType().ToString()}");

            var1 = 12.12m;
            Console.WriteLine($"{var1}: {var1.GetType().ToString()}");
        }
    }
}
