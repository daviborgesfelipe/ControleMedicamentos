using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;

namespace ControleMedicamentos.ConsoleApp.ModuloRemedio
{
    internal class Medicamentos : EntidadeBase
    {
        public string Descricao { get; set; }
        public int QntdDisponivel { get; set; }
        public int QntdLimite { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public List<Movimentacao> HistoricoRequisicoes { get; set; }

    }
}
