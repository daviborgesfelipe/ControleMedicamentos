using ControleMedicamentos.ConsoleApp.Compartilhado.Interfaces;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleMedicamentos.ConsoleApp.Compartilhado.Bases
{
    public class MovimentacaoBase : EntidadeBase
    {
        public Medicamentos Medicamento { get; set; }
        public Funcionario Funcionario { get; set; }
        public string Data { get; set; }
        public int QntdMedicamento { get; set; }

        public virtual void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
        }
    }
}
