using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class TelaEntradaMedicamento : TelaBase
    {
        private RepositorioEntradaMedicamento _repositorioEntradaMedicamento;
        private RepositorioFuncionario _repositorioFuncionario;
        private RepositorioMedicamento _repositorioMedicamento;

        private TelaFuncionario _telaFuncionario;
        private TelaMedicamentos _telaMedicamentos;
        public TelaEntradaMedicamento
            (
            RepositorioEntradaMedicamento repositorioEntradaMedicamento,
            RepositorioFuncionario repositorioFuncionario,
            RepositorioMedicamento repositorioMedicamento,
            TelaFuncionario telaFuncionario,
            TelaMedicamentos telaMedicamentos
            )
        {
            this.repositorioBase = repositorioEntradaMedicamento;

            this._repositorioEntradaMedicamento = repositorioEntradaMedicamento;
            this._repositorioFuncionario = repositorioFuncionario;
            this._repositorioMedicamento = repositorioMedicamento;
            this._telaFuncionario = telaFuncionario;
            this._telaMedicamentos = telaMedicamentos;
            
            nomeEntidade = "Entrada Medicamento";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -20} | {3, -20} | {4}", "Id", "Data", "Medicamento", "Funcionario", "Fonecedor", "Quantidade");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            foreach (EntradaMedicamento entradaMedicamento in registros)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -20} | {3, -20} | {4}",
                    entradaMedicamento.Id,
                    entradaMedicamento.data.ToShortDateString(),
                    entradaMedicamento.medicamento.nome,
                    entradaMedicamento.funcionario.nome,
                    entradaMedicamento.medicamento.fornecedor.nome,
                    entradaMedicamento.quantidade);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Medicamentos medicamento = ObterMedicamento();
            Funcionario funcionario = ObterFuncionario();
            Console.Write("Digite a quantidade de caixas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            return new EntradaMedicamento(medicamento, quantidade, data, funcionario);
        }
        public override void EditarRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}", $"Editando um registro de {nomeEntidade} já cadastrado...");
            VisualizarRegistros(false);
            Console.WriteLine();
            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            EntradaMedicamento aquisicao = _repositorioEntradaMedicamento.SelecionarPorId(id);
            EntidadeBase registroAtualizado = ObterRegistro();
            aquisicao.DesfazerRegistroEntrada();
            repositorioBase.Editar(id, registroAtualizado);
            MostrarMensagem($"Registro de {nomeEntidade} editado com sucesso!", ConsoleColor.Green);
        }
        public override void ExcluirRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}", "Excluindo um registro já cadastrado...");
            VisualizarRegistros(false);
            Console.WriteLine();
            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            EntradaMedicamento entradaMedicamento = _repositorioEntradaMedicamento.SelecionarPorId(id);
            entradaMedicamento.DesfazerRegistroEntrada();
            repositorioBase.Excluir(id);

            MostrarMensagem($"Registro de {nomeEntidade} excluído com sucesso!", ConsoleColor.Green);
        }
        private Funcionario ObterFuncionario()
        {
            _telaFuncionario.VisualizarRegistros(false);
            Console.Write("\nDigite o id do Funcionário: ");
            int idFuncionario = Convert.ToInt32(Console.ReadLine());
            Funcionario funcionario = _repositorioFuncionario.SelecionarPorId(idFuncionario);
            Console.WriteLine();
            return funcionario;
        }
        private Medicamentos ObterMedicamento()
        {
            _telaMedicamentos.VisualizarRegistros(false);
            Console.Write("\nDigite o id do Medicamento: ");
            int idMedicamento = Convert.ToInt32(Console.ReadLine());
            Medicamentos medicamento = _repositorioMedicamento.SelecionarPorId(idMedicamento);
            Console.WriteLine();
            return medicamento;
        }
    }
}
