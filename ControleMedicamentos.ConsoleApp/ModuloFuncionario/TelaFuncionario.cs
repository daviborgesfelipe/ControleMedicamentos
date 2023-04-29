using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
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

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2}", "Id", "Nome", "Login");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Funcionario funcionario in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2}", funcionario.Id, funcionario.nome, funcionario.login);
            }
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

    }
}
