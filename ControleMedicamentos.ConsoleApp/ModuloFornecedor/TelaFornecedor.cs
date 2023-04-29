using ControleMedicamentos.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public TelaFornecedor(RepositorioFornecedor _repositorioFornecedor)
        {
            this.repositorioBase = _repositorioFornecedor;
            nomeEntidade = "fornecedor";
            sufixo = "es";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Telefone");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Fornecedor fornecedor in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", fornecedor.Id, fornecedor.Nome, fornecedor.Telefone);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            Console.Write("Digite a cidade: ");
            string cidade = Console.ReadLine();
            Console.Write("Digite o estado: ");
            string estado = Console.ReadLine();
            return new Fornecedor(nome, telefone, email, cidade, estado);
        }
    }
}
