using System;

namespace CursoCSharp.Fundamentos
{
    public class NotacaoPonto
    {
        /// <summary>
        /// Usando ponto da acesso a funções aplicaveis
        /// chamadas de outras funções existentes
        /// quando se tem () é um método
        /// </summary>
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, "Word");

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // o ? garente que o valorImportante será acessado somente se tiver valor
            
            
        }
    }
}