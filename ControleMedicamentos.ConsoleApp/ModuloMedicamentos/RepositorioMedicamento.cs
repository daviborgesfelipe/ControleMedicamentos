using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamentos
{
    internal class RepositorioMedicamento : RepositorioBase
    {
        public RepositorioMedicamento(ArrayList listaMedicamento)
        {
            this.lista = listaMedicamento;
        }

        public override Medicamentos SelecionarPorId(int id)
        {
            return (Medicamentos)base.SelecionarPorId(id);
        }
    }
}
