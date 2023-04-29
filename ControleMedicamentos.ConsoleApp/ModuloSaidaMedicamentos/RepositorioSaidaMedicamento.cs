using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao
{
    internal class RepositorioSaidaMedicamento : RepositorioBase
    {
        public RepositorioSaidaMedicamento(ArrayList listaSaidaMedicamento)
        {
            this.lista = listaSaidaMedicamento;
        }
        public override SaidaMedicamento SelecionarPorId(int id)
        {
            return (SaidaMedicamento)base.SelecionarPorId(id);
        }
    }
}
