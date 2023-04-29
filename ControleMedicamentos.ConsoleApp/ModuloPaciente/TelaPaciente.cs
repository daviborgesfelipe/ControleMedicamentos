using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class TelaPaciente : TelaBase
    {
        public TelaPaciente(RepositorioPaciente repositorioPaciente)
        {
            this.repositorioBase = repositorioPaciente;
            nomeEntidade = "paciente";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2}", "Id", "Nome", "Cartão SUS");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (Paciente paciente in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2}", paciente.Id, paciente.nome, paciente.cartaoSus);
            }
        }
        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número do cartão do SUS: ");
            string cartaoSUS = Console.ReadLine();

            return new Paciente(nome, cartaoSUS);
        }
    }
}
