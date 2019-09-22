using System;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un valor para el primer String");
            String a = Console.ReadLine();
            Console.WriteLine("Introduce un valor para el primer String");
            String b = Console.ReadLine();


            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(a + b);
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}