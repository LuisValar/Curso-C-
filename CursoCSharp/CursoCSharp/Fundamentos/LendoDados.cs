using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine(" Qual é seu nome? ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            // Parse conver o dado, neste caso uma string em int

            Console.WriteLine("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine($"O {nome} tem {idade} anos e recebe R${salario}");
            
        }

    }
}