using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamentos
{
    internal class TelaMedicamentos : TelaBase
    {
        private RepositorioMedicamento repositorioMedicamento;
        private RepositorioFornecedor repositorioFornecedor;
        private TelaFornecedor telaFornecedor;

        public TelaMedicamentos(RepositorioMedicamento repositorioMedicamento, RepositorioFornecedor repositorioFornecedor, TelaFornecedor telaFornecedor)
        {
            this.repositorioMedicamento = repositorioMedicamento;
            this.repositorioFornecedor = repositorioFornecedor;
            this.telaFornecedor = telaFornecedor;
        }

        internal int InteragirMenuMedicamentos()
        {
            Console.Clear();
            Console.WriteLine("Menu Medicamentos");
            Console.WriteLine();
            Console.WriteLine("Selecione a opcao desejada");
            Console.WriteLine();
            Console.WriteLine("[1] Vizualizar todos medicamentos");
            Console.WriteLine("[2] Adicionar medicamentos");
            Console.WriteLine("[3] Editar medicamentos");
            Console.WriteLine("[4] Excluir medicamentos");
            Console.WriteLine("[0] Votlar menu inicial");
            Console.WriteLine();
            int opcaoMenu = Convert.ToInt32(Console.ReadLine());
            return opcaoMenu;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            throw new NotImplementedException();
        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
