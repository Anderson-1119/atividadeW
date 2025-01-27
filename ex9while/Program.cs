using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalCompras = 0;
            double valorCompra;
            Console.WriteLine("Digite o valor das compras (0 para sair):");
            while (true)
            {
                valorCompra = Convert.ToDouble(Console.ReadLine());
                if (valorCompra == 0) break;
                totalCompras += valorCompra;
            }
            Console.WriteLine($"Total de compras: {totalCompras}");
        }
    }
}
