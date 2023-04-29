using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using ControleMedicamentos.ConsoleApp.Compartilhado.Interfaces;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class EntradaMedicamento : EntidadeBase
    {
        public Medicamentos medicamento;
        public int quantidade;
        public DateTime data;
        public Funcionario funcionario;
        public EntradaMedicamento(Medicamentos medicamento, int quantidade, DateTime data, Funcionario funcionario)
        {
            this.medicamento = medicamento;
            this.quantidade = quantidade;
            this.data = data;
            this.funcionario = funcionario;

            this.medicamento.AdicionarQuantidade(quantidade);
        }

        public void DesfazerRegistroEntrada()
        {
            medicamento.RemoverQuantidade(quantidade);
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            EntradaMedicamento requisicaoEntradaAtualizada = (EntradaMedicamento)registroAtualizado;

            this.medicamento = requisicaoEntradaAtualizada.medicamento;
            this.quantidade = requisicaoEntradaAtualizada.quantidade;
            this.data = requisicaoEntradaAtualizada.data;
            this.funcionario = requisicaoEntradaAtualizada.funcionario;
        }
    }
}
