using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            string[] aux = Console.ReadLine().Split(' ');
            string a = aux[0];
            string b = aux[1];
            string c = aux[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
