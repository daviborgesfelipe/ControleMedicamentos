using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public int InteragirMenuFornecedor()
        {
            Console.Clear();
            Console.WriteLine("Menu Fornecedor");
            Console.WriteLine();
            Console.WriteLine("Selecione a opcao desejada");
            Console.WriteLine();
            Console.WriteLine("[1] Visualizar quantidade medicamentos");
            Console.WriteLine("[2] Reponder aquisicao de medicamentos");
            Console.WriteLine("[3] Visualizar aquisicao de medicamentos");
            Console.WriteLine();
            int opcaoMenu = Convert.ToInt32(Console.ReadLine());
            return opcaoMenu;
        }
    }
}
