using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalpassagens = 0;
            double valorPassagem;
            Console.WriteLine("Digite o valor das passagens vendidas (valor negativo para sair):");
            while (true)
            { 
                valorPassagem = Convert.ToDouble(Console.ReadLine());
            if (valorPassagem < 0) break;
            totalpassagens++;
        }
        Console.WriteLine($"Total de passagens vendidas: {totalpassagens}"); 
        }
    }
}
