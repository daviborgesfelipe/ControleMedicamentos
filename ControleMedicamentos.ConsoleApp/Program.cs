using ControleMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisicao;
using System.Collections;

namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            RepositorioFornecedor _repositorioFornecedor = new RepositorioFornecedor(new ArrayList());
            RepositorioFuncionario _repositorioFuncionario = new RepositorioFuncionario(new ArrayList());
            RepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new ArrayList());
            RepositorioEntradaMedicamento _repositorioEntradaMedicamento = new RepositorioEntradaMedicamento(new ArrayList());
            RepositorioSaidaMedicamento _repositorioSaidaMedicamento = new RepositorioSaidaMedicamento(new ArrayList());
            RepositorioMedicamento _repositorioMedicamento = new RepositorioMedicamento(new ArrayList());

            TelaFornecedor _telaFornecedor = new TelaFornecedor(_repositorioFornecedor);
            TelaFuncionario _telaFuncionario = new TelaFuncionario(_repositorioFuncionario);
            TelaPaciente _telaPaciente = new TelaPaciente(_repositorioPaciente);
            TelaMedicamentos _telaMedicamentos = new TelaMedicamentos(
                _repositorioMedicamento,
                _repositorioFornecedor,
                _telaFornecedor
                );
            
            TelaSaidaMedicamento _telaSaidaMedicamento = new TelaSaidaMedicamento(
                _repositorioSaidaMedicamento,
                _repositorioFuncionario,
                _repositorioMedicamento,
                _telaFuncionario,
                _telaMedicamentos
                );
            TelaEntradaMedicamento _telaEntradaMedicamento = new TelaEntradaMedicamento(
                _repositorioEntradaMedicamento,
                _repositorioFuncionario,
                _repositorioMedicamento,
                _telaFuncionario,
                _telaMedicamentos
                );

            while (true)
            {

                int opcao = program.InteragirMenuInicial();
                switch (opcao)
                {
                    case 1:
                        int opcaoMenuFuncionario = _telaFuncionario.InteragirMenu();
                        switch (opcaoMenuFuncionario)
                        {
                            case 1:
                                _telaFuncionario.InserirNovoRegistro();
                                break;
                            case 2:
                                _telaFuncionario.VisualizarRegistros(true);
                                Console.ReadLine();
                                break;
                            case 3:
                                _telaFuncionario.EditarRegistro();
                                break;
                            case 4:
                                _telaFuncionario.ExcluirRegistro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        int opcaoMenuFornecedor = _telaFornecedor.InteragirMenu();
                        switch (opcaoMenuFornecedor)
                        {
                            case 1:
                                _telaFornecedor.InserirNovoRegistro();
                                break;
                            case 2:
                                _telaFornecedor.VisualizarRegistros(true);
                                Console.ReadLine();
                                break;
                            case 3:
                                _telaFornecedor.EditarRegistro();
                                break;
                            case 4:
                                _telaFornecedor.ExcluirRegistro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        //MENU PACIENTE
                        int opcaoMenuPaciente = _telaPaciente.InteragirMenu();
                        switch (opcaoMenuPaciente)
                        {
                            case 1:
                                _telaPaciente.InserirNovoRegistro();
                                break;
                            case 2:
                                _telaPaciente.VisualizarRegistros(true);
                                Console.ReadLine();
                                break;
                            case 3:
                                _telaPaciente.EditarRegistro();
                                break;
                            case 4:
                                _telaPaciente.ExcluirRegistro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        //MENU ENTRADA
                        int opcaoMenuEntradaMedicamento = _telaEntradaMedicamento.InteragirMenu();
                        switch (opcaoMenuEntradaMedicamento)
                        {
                            case 1:
                                _telaEntradaMedicamento.InserirNovoRegistro();
                                break;
                            case 2:
                                _telaEntradaMedicamento.VisualizarRegistros(true);
                                Console.ReadLine();
                                break;
                            case 3:
                                _telaEntradaMedicamento.EditarRegistro();
                                break;
                            case 4:
                                _telaEntradaMedicamento.ExcluirRegistro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        //MENU SAIDA
                        int opcaoMenuSaidaMedicamento = _telaSaidaMedicamento.InteragirMenu();
                        switch (opcaoMenuSaidaMedicamento)
                        {
                            case 1:
                                _telaSaidaMedicamento.InserirNovoRegistro();
                                break;
                            case 2:
                                _telaSaidaMedicamento.VisualizarRegistros(true);
                                Console.ReadLine();
                                break;
                            case 3:
                                _telaSaidaMedicamento.EditarRegistro();
                                break;
                            case 4:
                                _telaSaidaMedicamento.ExcluirRegistro();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 6:
                        //MENU MEDICAMENTOS
                        int opcaoMenuMedicamentos = _telaMedicamentos.InteragirMenu();
                        switch (opcaoMenuMedicamentos)
                        {
                            case 1:
                                _telaMedicamentos.InserirNovoRegistro();
                                break;
                            case 2:
                                _telaMedicamentos.VisualizarRegistros(true);
                                Console.ReadLine();
                                break;
                            case 3:
                                _telaMedicamentos.EditarRegistro();
                                break;
                            case 4:
                                _telaMedicamentos.ExcluirRegistro();
                                break;
                            default:
                                break;
                        }
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
            Console.WriteLine("[1] - Funcionario");
            Console.WriteLine("[2] - Fornecedor");
            Console.WriteLine("[3] - Paciente");
            Console.WriteLine("[4] - Entrada Medicamentos");
            Console.WriteLine("[5] - Saida Medicamentos");
            Console.WriteLine("[6] - Medicamentos");
            Console.WriteLine();
            int opcaoMenuInicial = Convert.ToInt32(Console.ReadLine());
            return opcaoMenuInicial;
        }

    }
}