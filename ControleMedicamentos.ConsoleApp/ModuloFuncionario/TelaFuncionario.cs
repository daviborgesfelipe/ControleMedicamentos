using ControleMedicamentos.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class TelaFuncionario : TelaBase
    {
        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioBase = repositorioFuncionario;
            nomeEntidade = "funcionário";
            sufixo = "s";
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o login: ");
            string login = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();
            return new Funcionario(nome, login, senha);
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            throw new NotImplementedException();
        }

    }
}
