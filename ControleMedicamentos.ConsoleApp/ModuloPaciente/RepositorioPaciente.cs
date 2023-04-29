using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class RepositorioPaciente : RepositorioBase
    {
        public RepositorioPaciente(ArrayList listaPaciente)
        {
            this.lista = listaPaciente;
        }
        public override Paciente SelecionarPorId(int id)
        {
            return (Paciente)base.SelecionarPorId(id);
        }
    }
}
