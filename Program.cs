﻿using System;

namespace Taller_ComplejidadCiclo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de z = ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de w = ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de v = ");
            int v = int.Parse(Console.ReadLine());
            bool a = (x>4), b = (y==3), c = (z>3), d = (w<1), e = (v==1); 
            if (a==true)
            {
                if (b == true)
                {
                    Console.WriteLine("'x es mayor que 4' y 'y es es igual a 3'");
                }
                else
                {
                    if(c==true)
                    {
                        Console.WriteLine("'x es mayor a 4', 'y no es igual a 3' y 'z es mayor que 3'");
                    }
                    else
                    {
                        Console.WriteLine("'x es mayor a 4', 'y no es igual a 3' y 'z no es mayor que 3'");
                    }
                }
            }
            else
            {
                Console.WriteLine("'x no es mayor que 4'");
                if(d == true)
                {
                    if(e == true)
                    {
                        Console.WriteLine("'x no es mayor que 4', 'w es menor que 1' y 'v es igual a 1'");
                    }
                    else
                    {
                        Console.WriteLine("'x no es mayor que 4', 'w es menor que 1' y 'v no es igual a 1'");
                    }
                }
                else
                {
                    Console.WriteLine("'x no es mayor que 4' y 'w no es menor que 1'");
                }
            }
        }
    }
}
