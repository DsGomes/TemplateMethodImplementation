using System;
using TemplateMethod.Models;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matr = {1,2,3,4};
            double[] nota = {60, 70, 80, 90};
            SistemaPrintNotas spn = new SistemaPrintNotas(matr, nota);
            spn.print();

            Console.WriteLine("======= Retorno customizado utilizando Template Method =======");

            CustomPrintNotas cpn = new CustomPrintNotas(matr, nota);
            cpn.print();
        }
    }
}