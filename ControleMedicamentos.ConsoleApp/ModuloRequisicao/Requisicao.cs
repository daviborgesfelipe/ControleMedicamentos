using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class Requisicao : Movimentacao
    {
        public Paciente Paciente { get; set; }
    }
}
