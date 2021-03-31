namespace TemplateMethod.Models
{
    public abstract class Exame
    {
        protected int[] matr = new int[10];
        protected double[] nota = new double [10];
        
        public Exame(int [] matr, double[] nota) {
            this.matr = matr;
            this.nota = nota;
        }
        
        public double calcMedia() {
            double total = 0;

            for (int i = 0; i < this.matr.Length; i++)
                total = total + this.nota[i];
            
            return total / this.matr.Length;
        }
        
        public abstract void print();
    }
}