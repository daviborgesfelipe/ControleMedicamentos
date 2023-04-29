using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class TelaSaidaMedicamento : TelaBase
    {
        private RepositorioSaidaMedicamento _repositorioSaidaMedicamento;
        private RepositorioFuncionario _repositorioFuncionario;
        private RepositorioMedicamento _repositorioMedicamento;
        private RepositorioPaciente _repositorioPaciente;
        private TelaFuncionario _telaFuncionario;
        private TelaMedicamentos _telaMedicamentos;
        private TelaPaciente _telaPaciente;

        public TelaSaidaMedicamento(
            RepositorioSaidaMedicamento repositorioSaidaMedicamento,
            RepositorioFuncionario repositorioFuncionario,
            RepositorioMedicamento repositorioMedicamento,
            RepositorioPaciente repositorioPaciente,
            TelaFuncionario telaFuncionario,
            TelaMedicamentos telaMedicamentos,
            TelaPaciente telaPaciente
            )
        {
            this.repositorioBase = repositorioSaidaMedicamento;

            this._repositorioSaidaMedicamento = repositorioSaidaMedicamento;
            this._repositorioFuncionario = repositorioFuncionario;
            this._repositorioMedicamento = repositorioMedicamento;
            this._repositorioPaciente = repositorioPaciente;
            this._telaFuncionario = telaFuncionario;
            this._telaMedicamentos = telaMedicamentos;
            this._telaPaciente = telaPaciente;

            nomeEntidade = "Saida Medicamentos";
        }
        public override void EditarRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}", "Editando um registro já cadastrado...");
            VisualizarRegistros(false);
            Console.WriteLine();
            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            SaidaMedicamento saidaMedicamento = _repositorioSaidaMedicamento.SelecionarPorId(id);
            EntidadeBase registroAtualizado = ObterRegistro();
            saidaMedicamento.DesfazerRegistroSaida();
            repositorioBase.Editar(id, registroAtualizado);
            MostrarMensagem("Registro editado com sucesso!", ConsoleColor.Green);
        }
        public override void ExcluirRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}", "Excluindo um registro já cadastrado...");
            VisualizarRegistros(false);
            Console.WriteLine();
            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            SaidaMedicamento saidaMedicamento = _repositorioSaidaMedicamento.SelecionarPorId(id);
            saidaMedicamento.DesfazerRegistroSaida();
            repositorioBase.Excluir(id);
            MostrarMensagem($"Registro de {nomeEntidade} excluído com sucesso!", ConsoleColor.Green);
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            const string FORMATO_TABELA = "{0, -10} | {1, -10} | {2, -20} | {3, -20} | {4, -20} | {5, -20} | {6}";

            Console.WriteLine(FORMATO_TABELA, "Id", "Data", "Medicamento", "Funcionario", "Fonecedor", "Paciente", "Quantidade");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (SaidaMedicamento saidaMedicamento in registros)
            {
                Console.WriteLine(FORMATO_TABELA,
                    saidaMedicamento.Id,
                    saidaMedicamento.data.ToShortDateString(),
                    saidaMedicamento.medicamento.nome,
                    saidaMedicamento.funcionario.nome,
                    saidaMedicamento.medicamento.fornecedor.nome,
                    saidaMedicamento.paciente.nome,
                    saidaMedicamento.quantidade);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Medicamentos medicamento = ObterMedicamento();
            Funcionario funcionario = ObterFuncionario();
            Paciente paciente = ObterPaciente();
            Console.Write("Digite a quantidade de caixas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            return new SaidaMedicamento(medicamento, quantidade, data, funcionario, paciente);
        }
        private Paciente ObterPaciente()
        {
            _telaPaciente.VisualizarRegistros(false);
            Console.Write("\nDigite o id do Funcionário: ");
            int idPaciente = Convert.ToInt32(Console.ReadLine());
            Paciente paciente = _repositorioPaciente.SelecionarPorId(idPaciente);
            Console.WriteLine();
            return paciente;
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
