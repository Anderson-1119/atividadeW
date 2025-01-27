using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10for
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double totalPassagens = 0;
            double valorPassagem;
            for (; ; )
            { 
                Console.WriteLine("Digite o valor das passagens vendidas (valor negativo para sair):");
            valorPassagem = Convert.ToDouble(Console.ReadLine());
            if (valorPassagem < 0) break;
            totalPassagens++;
        }
        Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");
        }
    }
}
