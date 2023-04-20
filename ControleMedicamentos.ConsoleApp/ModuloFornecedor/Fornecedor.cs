using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class Fornecedor : Usuario
    {
        public int CNPJ { get; set; }

        public List<Medicamentos> Medicamentos { get; set; }     
    }
}
