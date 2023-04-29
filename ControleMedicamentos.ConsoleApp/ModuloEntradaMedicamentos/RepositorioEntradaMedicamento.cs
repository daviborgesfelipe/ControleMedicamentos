using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using ControleMedicamentos.ConsoleApp.Compartilhado.Interfaces;
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
