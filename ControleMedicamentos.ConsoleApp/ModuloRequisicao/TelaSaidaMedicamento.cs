using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class TelaSaidaMedicamento : TelaBase
    {
        private RepositorioSaidaMedicamento repositorioSaidaMedicamento;
        private RepositorioFuncionario repositorioFuncionario;
        private RepositorioMedicamento repositorioMedicamento;
        private TelaFuncionario telaFuncionario;
        private TelaMedicamentos telaMedicamentos;

        public TelaSaidaMedicamento(
            RepositorioSaidaMedicamento repositorioSaidaMedicamento,
            RepositorioFuncionario repositorioFuncionario,
            RepositorioMedicamento repositorioMedicamento,
            TelaFuncionario telaFuncionario,
            TelaMedicamentos telaMedicamentos
            )
        {
            this.repositorioSaidaMedicamento = repositorioSaidaMedicamento;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioMedicamento = repositorioMedicamento;
            this.telaFuncionario = telaFuncionario;
            this.telaMedicamentos = telaMedicamentos;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            const string FORMATO_TABELA = "{0, -10} | {1, -10} | {2, -20} | {3, -20} | {4, -20} | {5, -20}";

            Console.WriteLine(FORMATO_TABELA, "Id", "Data", "Medicamento", "Fonecedor", "Paciente", "Quantidade");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (SaidaMedicamento saidaMedicamento in registros)
            {
                Console.WriteLine(FORMATO_TABELA,
                    saidaMedicamento.Id,
                    saidaMedicamento.data.ToShortDateString(),
                    saidaMedicamento.medicamento.nome,
                    saidaMedicamento.medicamento.fornecedor.nome,
                    saidaMedicamento.paciente.Nome,
                    saidaMedicamento.quantidade);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
