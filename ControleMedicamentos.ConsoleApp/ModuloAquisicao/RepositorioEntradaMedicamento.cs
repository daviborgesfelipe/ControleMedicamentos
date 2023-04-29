using ControleMedicamentos.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class RepositorioEntradaMedicamento : RepositorioBase
    {
        public RepositorioEntradaMedicamento(ArrayList listaEntradaMedicamentos)
        {
            this.lista = listaEntradaMedicamentos;
        }

        public override EntradaMedicamento SelecionarPorId(int id)
        {
            return (EntradaMedicamento)base.SelecionarPorId(id);
        }
    }
}
