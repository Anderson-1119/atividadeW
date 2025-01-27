using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace despesas_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double despesas = 0;
            double despesa;
            Console.WriteLine("Digite suas despesas (valor negativo para sair):");
            while (true)
            {
                despesa = Convert.ToDouble(Console.ReadLine());
                if (despesa < 0) break;
                despesas += despesa;
            }
            Console.WriteLine($"Total de despesas: {despesas}");
        }
    }
}
