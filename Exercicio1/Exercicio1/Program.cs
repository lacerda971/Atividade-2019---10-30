﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cont = 1;

            while (cont <= 10000)
            {
                
                Console.WriteLine(cont);

                cont = cont + 1;
            }
            Console.ReadKey();
        }
    }
}
