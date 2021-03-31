using System;

namespace TemplateMethod.Models
{
    public class CustomPrintNotas : Exame
    {
        public CustomPrintNotas(int[] matr, double[] nota) : base(matr, nota) {}

        public override void print()
        {
            
            for (int i = 0; i < matr.Length; i++) {
                Console.WriteLine("Matrícula: " + matr[i]);
                Console.WriteLine("Nota: " + nota[i]);
            }
            
            Console.WriteLine("============="); 
            Console.WriteLine("Nota media do curso: " + calcMedia()); 
        }
    }
}