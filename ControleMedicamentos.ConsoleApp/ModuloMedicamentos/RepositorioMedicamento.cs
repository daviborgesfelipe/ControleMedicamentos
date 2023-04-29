using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
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
        public ArrayList SelecionarMedicamentosEmFalta()
        {
            ArrayList listaMedicamentosEmFalta = new ArrayList();
            foreach (Medicamentos medicamento in lista)
            {
                if (medicamento.quantidade == 0)
                    listaMedicamentosEmFalta.Add(medicamento);
            }
            return listaMedicamentosEmFalta;
        }
        public ArrayList SelecionarMedicamentosMaisRetirados()
        {
            Medicamentos[] medicamentos = new Medicamentos[lista.Count];
            int posicao = 0;
            foreach (Medicamentos medicamento in lista)
            {
                medicamentos[posicao++] = medicamento;
            }
            Array.Sort(medicamentos, new ComparadorMedicamentosRetirados());
            return new ArrayList(medicamentos);
        }
    }
}
