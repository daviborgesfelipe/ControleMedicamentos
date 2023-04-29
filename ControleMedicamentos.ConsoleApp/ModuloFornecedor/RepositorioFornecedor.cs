using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    public class RepositorioFornecedor : RepositorioBase
    {
        public RepositorioFornecedor(ArrayList listaForcedor)
        {
            this.lista = listaForcedor;
        }
        public override Fornecedor SelecionarPorId(int id)
        {
            return (Fornecedor)base.SelecionarPorId(id);
        }
    }
}
