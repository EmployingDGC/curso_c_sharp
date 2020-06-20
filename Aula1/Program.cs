using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                  | BYTES | POSSÍVEIS VALORES

            sbyte   x1  = 0;                 // |    1  | -128 até 127
            short   x2  = 256;               // |    2  | -32768 até 32767
            int     x3  = -3276800;          // |    4  | -2 ^ 31 até 2 ^ 31 - 1
            long    x4  = 5241575L;          // |    8  | -2 ^ 63 até 2 ^ 63 - 1
            byte    x5  = 148;               // |    1  | 0 até 255
            ushort  x6  = 52470;             // |    2  | 0 até 65535
            uint    x7  = 3295962579;        // |    4  | 0 até 2 ^ 32 - 1
            ulong   x8  = 5651898772159478L; // |    8  | 0 até 2 ^ 64 - 1
            float   x9  = 1.755F;            // |    4  | ±1.5 * 10 ^ -45 até ±3.4 * 10 ^ 38 com 7 números significativos
            double  x10 = 1.521323132352;    // |    8  | ±5.0 * 10 ^ -324 até ±1.7 * 10 ^ 308 com 15 ou 16 números significativos
            decimal x11 = 1.1231M;           // |   12  | ±1.0 * 10 ^ -28 até ±7.9 * 10 ^ 28 com 28 ou 29 números significativos
            char    x12 = '\u0041';          // |    2  | Qualquer caractere Unicode
            bool    x13 = true;              // |  1/2  | true ou false

            string  x14 = "Davi GC";         // |       | Conjunto de caracteres
            object  x15 = 23;                // |       | Variável genérica

            // Nomes de variáveis

            string lastName;  // Camel Case (Parâmetros de metodos, variáveis de métodos)

            string LastName;  // Pascal Case (namespaces, classes, properties, métodos)

            string _lastName; // Camel Case com underline (atributos "internos" da classe)

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
            Console.WriteLine(x6);
            Console.WriteLine(x7);
            Console.WriteLine(x8);
            Console.WriteLine(x9);
            Console.WriteLine(x10);
            Console.WriteLine(x11);
            Console.WriteLine(x12);
            Console.WriteLine(x13);
            Console.WriteLine(x14);
            Console.WriteLine(x15);
            
            Console.WriteLine(sbyte.MinValue);   // Serve pra todos os valores
            Console.WriteLine(decimal.MaxValue); // Serve pra todos os valores

            // Placeholders

            Console.WriteLine($"Nome: {x14}\nIdade: {x15}\nAltura: {x9:F2}");
        }
    }
}
