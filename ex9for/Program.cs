﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalcompras = 0;
            double valorCompra = 0;
            for (; ; )
            {
                Console.WriteLine("Digite o valor das compras (0 para sair):");
                valorCompra = Convert.ToDouble(Console.ReadLine());
                if (valorCompra== 0) break;
            totalcompras += valorCompra;
        }
        Console.WriteLine($"Total de compras: {totalcompras}");
        }
    }
}
