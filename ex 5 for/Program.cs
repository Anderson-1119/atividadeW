﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int totalEstoque = 0;
            for (; ; ) { 

        Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos (0 para sair):");
Console.Write("Recebidos: ");
int recebidos = Convert.ToInt32(Console.ReadLine());
if (recebidos == 0) break;
Console.Write("Vendidos: ");
int vendidos = Convert.ToInt32(Console.ReadLine());
totalEstoque += recebidos - vendidos;
    }
    Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");
        }
    }
}

