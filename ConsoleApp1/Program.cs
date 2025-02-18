/// Importando o System;
using System;
using System.Runtime.CompilerServices;
using ConsoleApp1.Class;

///Namespace da Aplicação
namespace ConsoleApp1
{
    /// <summary>
    /// Classe Program
    /// Responsavel acionar o Static Main do projeto, e executar o que está dentro do bloco de código
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Projeto Main
        /// Responsável por receber 3 informacoes digitadas pelo usuário ( Nome, Sobrenome e Idade )
        /// depois aciona a classe People passando essas informações via contrtutor
        /// e na sequencia mostra a mensagem de apresentacao
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("===== Boas Vindas =====");
            Console.WriteLine();
            Console.WriteLine("Qual o seu nome ? ");
            string nome = Console.ReadLine() ?? "Sem nome";

            Console.WriteLine();
            Console.WriteLine("Qual o seu sobrenome ? ");
            string sobrenome = Console.ReadLine() ?? "Sem sobrenome";

            Console.WriteLine();
            Console.WriteLine("Qual sua idade ? ");
            int idade = int.Parse(Console.ReadLine() ?? "Sem Idade");
            Console.WriteLine();

            People _pessoa = new People(nome, sobrenome, idade);
            Console.WriteLine(_pessoa.Apresentacao);
            Console.ReadKey();
        }
    }

}