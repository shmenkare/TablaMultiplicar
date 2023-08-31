using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, num = 0, resul = 0;

            Console.WriteLine("Ingresa el numero para sacar su tabla de multiplicar");
            num = Convert.ToInt32(Console.ReadLine());

            for (n = 1; n <= 10;n++)
            {
                Thread.Sleep(200);

                resul = num* n;

                Console.WriteLine("{0} x {1} = {2}", num, n, resul );

            }

            Console.ReadKey();
        }
    }
}
