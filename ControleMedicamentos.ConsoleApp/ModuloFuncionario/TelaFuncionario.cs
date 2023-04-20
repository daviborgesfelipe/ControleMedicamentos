using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class TelaFuncionario : TelaBase
    {
        public int InteragirMenuFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Menu Funcionarios");
            Console.WriteLine();
            Console.WriteLine("Selecione a opcao desejada");
            Console.WriteLine();
            Console.WriteLine("[1] Visualizar quantidade medicamentos");
            Console.WriteLine("[2] Visualizar requisicao de medicamentos");
            Console.WriteLine("[3] Responder requisicao de pacientes");
            Console.WriteLine("[3] Solicitar aquisicao com fornecedor");
            Console.WriteLine();
            int opcaoMenu = Convert.ToInt32(Console.ReadLine());
            return opcaoMenu;
        }
    }
}
