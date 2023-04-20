using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal class Movimentacao : EntidadeBase
    {
        public Medicamentos Medicamento{ get; set; }
        public Funcionario Funcionario { get; set; }
        public string Data { get; set; }
        public int QntdMedicamento { get; set; }
    }
}
