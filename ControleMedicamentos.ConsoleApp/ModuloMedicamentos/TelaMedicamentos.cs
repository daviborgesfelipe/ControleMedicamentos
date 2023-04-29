using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamentos
{
    internal class TelaMedicamentos : TelaBase
    {
        private RepositorioMedicamento _repositorioMedicamento;
        private RepositorioFornecedor _repositorioFornecedor;
        private TelaFornecedor _telaFornecedor;

        public TelaMedicamentos(
            RepositorioMedicamento repositorioMedicamento,
            RepositorioFornecedor repositorioFornecedor,
            TelaFornecedor telaFornecedor
            )
        {
            this.repositorioBase = repositorioMedicamento;

            this._repositorioMedicamento = repositorioMedicamento;
            this._repositorioFornecedor = repositorioFornecedor;
            this._telaFornecedor = telaFornecedor;

            nomeEntidade = "Medicamento";
            sufixo = "s";
        }
        
        public void VisulizarMedicamentosEmFalta()
        {
            MostrarCabecalho("Cadastro de Medicamentos", "Visualizando medicamentos em falta...");
            ArrayList medicamentosMaisRetirados = _repositorioMedicamento.SelecionarMedicamentosEmFalta();
            if (medicamentosMaisRetirados.Count == 0)
            {
                MostrarMensagem("Nenhum registro cadastrado", ConsoleColor.DarkYellow);
                return;
            }
            MostrarTabela(medicamentosMaisRetirados);
        }
        public void VisualizarMedicamentosMaisRetirados()
        {
            MostrarCabecalho("Cadastro de Medicamentos", "Visualizando medicamentos mais Retirados...");
            ArrayList medicamentosMaisRetirados = _repositorioMedicamento.SelecionarMedicamentosMaisRetirados();
            if (medicamentosMaisRetirados.Count == 0)
            {
                MostrarMensagem("Nenhum registro cadastrado", ConsoleColor.DarkYellow);
                return;
            }
            MostrarTabela(medicamentosMaisRetirados);
        }
        private Fornecedor ObterFornecedor()
        {
            _telaFornecedor.VisualizarRegistros(false);
            Console.Write("\nDigite o id do Forncedor: ");
            int idFornecedor = Convert.ToInt32(Console.ReadLine());
            Fornecedor fornecedor = _repositorioFornecedor.SelecionarPorId(idFornecedor);
            Console.WriteLine();
            return fornecedor;
        }
        
        public override int InteragirMenu()
        {
            Console.Clear();
            Console.WriteLine($"Cadastro de {nomeEntidade}{sufixo} \n");
            Console.WriteLine($"[1] - Inserir {nomeEntidade}{sufixo}");
            Console.WriteLine($"[2] - Visualizar {nomeEntidade}{sufixo}");
            Console.WriteLine($"[3] - Editar {nomeEntidade}");
            Console.WriteLine($"[4] - Excluir {nomeEntidade}");
            Console.WriteLine($"[5] - Visualizar {nomeEntidade}{sufixo} Mais Retirados");
            Console.WriteLine($"[6] - Visualizar {nomeEntidade}{sufixo} em Falta\n");
            Console.WriteLine($"[0] - Sair");
            int opcaoMenu = Convert.ToInt32(Console.ReadLine());
            return opcaoMenu;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4}", "Id", "Nome", "Fornecedor", "Quantidade", "Qtd Retiradas");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            foreach (Medicamentos medicamento in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20} | {4}",
                    medicamento.Id, medicamento.nome, medicamento.fornecedor.nome, medicamento.quantidade, medicamento.quantidadeRequisicoesSaida);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Fornecedor fornecedor = ObterFornecedor();
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o lote: ");
            string lote = Console.ReadLine();
            Console.Write("Digite a data de validade: ");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine());
            return new Medicamentos(nome, descricao, lote, dataValidade, fornecedor);
        }

    }
}
