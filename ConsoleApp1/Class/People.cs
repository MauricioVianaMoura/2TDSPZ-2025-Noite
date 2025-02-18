using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    /// <summary>
    /// Classe People
    /// </summary>
    public class People
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Apresentacao { get; set; }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public People()
        {

        }

        /// <summary>
        /// Construtor com 3 paramentros
        /// </summary>
        /// <param name="_nome"> Nome da pessoa</param>
        /// <param name="_sobrenome"> Sobrenome da pessoa </param>
        /// <param name="_idade"> Idade da pessoa </param>
        public People(string _nome, string _sobrenome, int _idade)
        {
            Nome = _nome;
            Sobrenome = _sobrenome;
            Idade = _idade;
            Apresentacao = MontarMensagemDeApresentacao(Nome, Sobrenome, Idade);
        }

        /// <summary>
        /// Método responsável por receber 3 informaçoes ( Nome , Sobrenome e Idade)
        /// e depois montart uma mensagem personalizada com as 3 informações em uma variável
        /// </summary>
        /// <param name="nome"> Nome da pessoa </param>
        /// <param name="sobrenome"> Sobrenome da pessoa </param>
        /// <param name="idade"> Idade da pessoa </param>
        /// <returns> Retorna a mensagem completa com os paramentros informado </returns>
        private static string MontarMensagemDeApresentacao(string nome, string sobrenome, int idade)
        {
            return "Meu nome é " + nome + " " + sobrenome + " e eu tenho " + idade + " anos!";
        }

    }
}
