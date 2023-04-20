using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class TelaPaciente : TelaBase
    {
        public int InteragirMenuPaciente()
        {
            Console.Clear();
            Console.WriteLine("Menu Paciente");
            Console.WriteLine();
            Console.WriteLine("Selecione a opcao desejada");
            Console.WriteLine();
            Console.WriteLine("[1] Visualizar quantidade medicamentos");
            Console.WriteLine("[2] Criar requisicao de medicamentos");
            Console.WriteLine("[3] Visualizar requisicao de medicamentos");
            Console.WriteLine();
            int opcaoMenu = Convert.ToInt32(Console.ReadLine());
            return opcaoMenu;
        }
    }
}
