using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2;
            string linea;
            
       
        Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            if ((NUM1 > NUM2))
            {
                Console.WriteLine("{0} ES MAYOR QUE {1}", NUM1, NUM2);
            }
            else
            {
                if ((NUM1 == NUM2))
                {
                    Console.WriteLine("{0} ES IGUAL A {1}", NUM1, NUM2);
                }
                else
                {
                    Console.WriteLine("{0} ES MENOR QUE {1}", NUM1, NUM2);
                }
            }
            Console.WriteLine();
            Console.WriteLine("OTRA MANERA");
            string RESUL;
            if (NUM1 > NUM2)
            {
                RESUL = "MAYOR";
            }
            else
            if (NUM1 == NUM2)
            {
                RESUL = "IGUAL";
            }
            else
            {
                RESUL = "MENOR";
            }

            Console.WriteLine("{0} ES {1} QUE {2}", NUM1, RESUL, NUM2);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();

        }
    }
}