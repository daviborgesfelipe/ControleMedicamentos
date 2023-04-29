using ControleMedicamentos.ConsoleApp.ModuloRemedio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamentos
{
    public class ComparadorMedicamentosRetirados : IComparer
    {
        public int Compare(object x, object y)
        {
            Medicamentos mX = (Medicamentos)x;
            Medicamentos mY = (Medicamentos)y;
            if (mX.quantidadeRequisicoesSaida < mY.quantidadeRequisicoesSaida)
            {
                return 1;
            }
            else if (mX.quantidadeRequisicoesSaida > mY.quantidadeRequisicoesSaida)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
