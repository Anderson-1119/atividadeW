using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double totalPassagens = 0;
            double valorPassagem;
            do
            {
                Console.WriteLine("Digite o valor das passagens vendidas (valor negativo para sair):");
                valorPassagem = Convert.ToDouble(Console.ReadLine());
                if (valorPassagem >= 0) totalPassagens++;
            } while (valorPassagem >= 8);
            Console.WriteLine($"Total de passagens vendidas: {totalPassagens}");
        }
    }
}
