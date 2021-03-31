using System;

namespace TemplateMethod.Models
{
    public class SistemaPrintNotas : Exame
    {
        public SistemaPrintNotas(int [] matr, double[] nota) : base(matr, nota){}
        
        public override void print()
        {
            Console.WriteLine("Matr\tNota"); // cabeçalho
            for (int i = 0; i < matr.Length; i++) {
            Console.WriteLine(matr[i] + "\t" + nota[i]);
            }
            Console.WriteLine("============="); // rodapé
            Console.WriteLine("Nota media: " + calcMedia()); // rodapé
        }
    }
}