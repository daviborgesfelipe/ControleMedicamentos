using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class SaidaMedicamento : Movimentacao
    {
        public Medicamentos medicamento;
        public int quantidade;
        public DateTime data;
        public Funcionario funcionario;

        public Paciente paciente;

        public SaidaMedicamento(Medicamentos medicamento, int quantidade, DateTime data,
            Funcionario funcionario, Paciente paciente)
        {
            this.medicamento = medicamento;
            this.data = data;
            this.funcionario = funcionario;
            this.paciente = paciente;
            this.quantidade = quantidade;

            this.medicamento.RemoverQuantidade(quantidade);
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            SaidaMedicamento saidaMedicamento = (SaidaMedicamento)registroAtualizado;

            this.medicamento = saidaMedicamento.medicamento;
            this.quantidade = saidaMedicamento.quantidade;
            this.data = saidaMedicamento.data;
            this.funcionario = saidaMedicamento.funcionario;
            this.paciente = saidaMedicamento.paciente;
        }

        public void DesfazerRegistroSaida()
        {
            medicamento.AdicionarQuantidade(quantidade);
        }
    }
}
