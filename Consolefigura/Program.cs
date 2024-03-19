using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefigura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o tipo de figura\nR retangulo -\nQ quadrado- \nLlosango -\nT trapézio");
            string figura = Console.ReadLine().ToUpper();

            double lado, area, base1, base2, diag1, diag2;
            switch (figura)
            {
                case "Q":
                    Console.WriteLine("informe o lado do quadrado");
                    lado = double.Parse(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine("a area do quadrado é: " + area.ToString("F3"));
                    break;
                case "R":
                    Console.WriteLine("informe o lado do retangulo");
                    lado = double.Parse(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine("a area do retangulo é: " + area.ToString("F3"));
                    break;
                case "T":
                    Console.WriteLine("informe o lado do trapezio");
                    lado = double.Parse(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine("a area do trapezio é: " + area.ToString("F3"));
                    break;
                case "L":
                    Console.WriteLine("informe o lado do losango");
                    lado = double.Parse(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine("a area do losango é: " + area.ToString("F3"));
                    break;

            }
            Console.ReadKey();
        }
    }
}
