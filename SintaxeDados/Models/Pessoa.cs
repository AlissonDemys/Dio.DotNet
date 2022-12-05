namespace SintaxeDados.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }   
        public double Altura { get; set; }

        public void Dados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Peso: " + Peso);
        }
        public void IMC()
        {
            double IMC = (Peso/(Altura*Altura));
            Console.WriteLine($"IMC:" + IMC.ToString("00.00"));

            if (IMC <= 18.4)
            {
                Console.WriteLine("Magreza 0");
            }
            if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Normal 0");
            } 
            if (IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine("Sobrepeso 1");
            }
            if (IMC >= 30 && IMC <= 39.9)
            {
                Console.WriteLine("Obesidade 2");
            }
            if (IMC >= 40)
            {
                Console.WriteLine("Obesidade 3");
            }
        }
    }
}