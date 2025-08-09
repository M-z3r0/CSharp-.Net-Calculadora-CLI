using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "***********************************************\n" +
                "*              Calculadora CLI                *\n" +
                "***********************************************\n" +
                "*  ---- Digite um número:                     *"
                );
            double n1 = Double.Parse( Console.ReadLine());
            Console.Write(
                "***********************************************\n" +
                "* ---- Digite agora qual operação você deseja:* \n" +
                "1 - Soma(+)" +
                "\n2 - Subtração(-)" +
                "\n3 - Multiplicação(*)" +
                "\n4 - Divisão(/)" +
                "\n: "
                );
            int opt = Int32.Parse(Console.ReadLine());
            Console.WriteLine(
             "***********************************************\n" +
             "* ---- Digite um outro Número número:         *"
             );
            double n2 = Double.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.Write($"{n1} + {n2} = {sum(n1, n2)}");
                    break;
                case 2:
                    Console.Write($"{n1} - {n2} = {sub(n1, n2)}");
                    break;
                case 3:
                    Console.Write($"{n1} - {n2} = {mult(n1, n2)}");
                    break;
                case 4:
                    Console.Write($"{n1} - {n2} = {div(n1, n2)}");
                    break;

            }

        }

        public static double sum(double n1, double n2)
        {   
            return n1 + n2;
        }
        public static double sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double mult(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double div(double n1, double n2)
        {
            return n1 / n2;
        }

    }
}
