using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double despesas = 0;
            double despesa;
           
            do
            {
                Console.WriteLine("Digite suas despesas (valor negativo para sair):");
                despesa = Convert.ToDouble(Console.ReadLine());
                if (despesa >= 0) despesas += despesa;
            } while (despesa >= 0);
            Console.WriteLine($"Total de despesas: {despesas}");
        }
    }
}
