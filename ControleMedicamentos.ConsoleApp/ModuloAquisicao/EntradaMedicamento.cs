using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class EntradaMedicamento : Movimentacao
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
    }
}
