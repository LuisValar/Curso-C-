using System;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5; // double = 8 bytes 
            const double PI = 3.14; // constantes não podem ser alteradas em nenhum momento

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);
            
            //Tipo internos

            bool estaChovendo = true; // ou false
            Console.WriteLine("Está chovendo aí? Aqui " + estaChovendo);

            byte idade = 1; //1 byte = 8 bits - não aceita negativos
            short shortSize = 2; // 2 bytes 
            int intSize = 4; // 4 bytes

            sbyte sbyteSize = sbyte.MinValue; // byte com sinal
            sbyte sbySize2 = sbyte.MaxValue; // tamanho maximo

            short salario = short.MaxValue;

            int menorValorInt = int.MinValue; //tamanho minimo do int
            int maiorValorInt = int.MaxValue; // tamanho maximo do int

            uint populacaoBrasileira = 207_600_000; // int sem sinal. será sempre positivo

            long menorValorLong = long.MinValue; // inteiro de 8 bytes

            ulong longSemSinal = 7_600_000_000; // long sem sinal

            float precoComputador = 1299.99f; // obrigado usar f
            
            decimal distanciaEntreEstrelas = Decimal.MaxValue;
            Console.WriteLine(Decimal.MaxValue);
            
            char letra = 'b';
            
            string texto = "aqui pode ser feito texto";
            
        }
    }
}