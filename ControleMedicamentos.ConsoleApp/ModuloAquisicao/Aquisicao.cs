using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;

namespace ControleMedicamentos.ConsoleApp.ModuloAquisicao
{
    internal class Aquisicao : Movimentacao
    {
        public Fornecedor Fornecedor { get; set; }
    }
}
