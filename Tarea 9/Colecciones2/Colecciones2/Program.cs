﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numeros = new List<int>(); //Declarar una lista (coleccion de tipo list)

            Console.WriteLine("Introduce elementos en la coleccion (0 para salir)");

            int elem = 1;

            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);


            Console.WriteLine("Elementos introducidos: ");

            foreach (int elemento in numeros) 
            {
            
                Console.WriteLine(elemento);

            }

        }
    }
}
