using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;

namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            
            TelaFornecedor _telaFornecedor = new TelaFornecedor();
            TelaFuncionario _telaFuncionario = new TelaFuncionario();
            TelaPaciente _telaPaciente = new TelaPaciente();

            while (true)
            {

                int opcao = program.InteragirMenuInicial();
                switch (opcao) 
                {
                    case 1:
                        //MENU PACIENTE
                        _telaFuncionario.InteragirMenuFuncionario();
                        break;
                    case 2:
                        //MENU FORNECEDOR
                        _telaFornecedor.InteragirMenuFornecedor();
                        break;
                    case 3:
                        //MENU FUNCIONARIO
                        _telaPaciente.InteragirMenuPaciente();
                        break;
                }
            }
        }
        public int InteragirMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Estoque Medicamentos");
            Console.WriteLine();
            Console.WriteLine("Selecione a opcao desejada");
            Console.WriteLine();
            Console.WriteLine("[1] Menu Funcionario");
            Console.WriteLine("[2] Menu Fornecedor");
            Console.WriteLine("[3] Menu Usuario");
            Console.WriteLine();
            int opcaoMenuInicial = Convert.ToInt32(Console.ReadLine());
            return opcaoMenuInicial;
        }
    }
}