using ControleMedicamentos.ConsoleApp.ModuloAquisicao;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamentos;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRemedio;
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
                _repositorioPaciente,
                _telaFuncionario,
                _telaMedicamentos,
                _telaPaciente
                );
            TelaEntradaMedicamento _telaEntradaMedicamento = new TelaEntradaMedicamento(
                _repositorioEntradaMedicamento,
                _repositorioFuncionario,
                _repositorioMedicamento,
                _telaFuncionario,
                _telaMedicamentos
                );
            CadastrarRegistros(
                _repositorioFuncionario,
                _repositorioFornecedor,
                _repositorioMedicamento,
                _repositorioPaciente,
                _repositorioEntradaMedicamento,
                _repositorioSaidaMedicamento
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
                            case 5:
                                _telaMedicamentos.VisualizarMedicamentosMaisRetirados();
                                break;
                            case 6:
                                _telaMedicamentos.VisulizarMedicamentosEmFalta();
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
        private static void CadastrarRegistros(
        RepositorioFuncionario repositorioFuncionario,
        RepositorioFornecedor repositorioFornecedor,
        RepositorioMedicamento repositorioMedicamento,
        RepositorioPaciente repositorioPaciente,
        RepositorioEntradaMedicamento repositorioEntradaMedicamento,
        RepositorioSaidaMedicamento repositorioSaidaMedicamento)
        {

            Funcionario funcionario1 = new Funcionario("Alexandre Rech", "rech", "123");
            Funcionario funcionario2 = new Funcionario("Tiago Santini", "santini", "456");

            repositorioFuncionario.Inserir(funcionario1);
            repositorioFuncionario.Inserir(funcionario2);

            Fornecedor fornecedor1 = new Fornecedor("Ultrafarma", "987654312", "ultrafarma@gmail.com", "São Paulo", "SP");
            Fornecedor fornecedor2 = new Fornecedor("Medica Super", "12345679", "medica@gmail.com", "Rio de Janeiro", "RJ");

            repositorioFornecedor.Inserir(fornecedor1);
            repositorioFornecedor.Inserir(fornecedor2);

            Medicamentos medicamento1 = new Medicamentos("Gliclazida", "Remédio p/ Diabetes", "321-987", new DateTime(2024, 01, 01), fornecedor1);
            Medicamentos medicamento2 = new Medicamentos("Entresto", "Remédio p/ Coração", "987-321", new DateTime(2024, 01, 01), fornecedor2);

            Medicamentos medicamento3 = new Medicamentos("Bisoprolol", "Remédio p/ Coração", "321-987", new DateTime(2024, 01, 01), fornecedor1);
            Medicamentos medicamento4 = new Medicamentos("Rosuvastatina", "Remédio p/ Triglicerídeos", "987-321", new DateTime(2024, 01, 01), fornecedor2);

            repositorioMedicamento.Inserir(medicamento1);
            repositorioMedicamento.Inserir(medicamento2);
            repositorioMedicamento.Inserir(medicamento3);
            repositorioMedicamento.Inserir(medicamento4);

            Paciente paciente1 = new Paciente("Gabriel Rech", "741258963");
            Paciente paciente2 = new Paciente("Palmira Souza", "582147852");
            Paciente paciente3 = new Paciente("Léo Rech", "111111111");
            Paciente paciente4 = new Paciente("Diane Rech", "222222222");

            repositorioPaciente.Inserir(paciente1);
            repositorioPaciente.Inserir(paciente2);
            repositorioPaciente.Inserir(paciente3);
            repositorioPaciente.Inserir(paciente4);

            EntradaMedicamento requisicaoEntrada1 = new EntradaMedicamento(medicamento1, 22, DateTime.Now, funcionario2);
            EntradaMedicamento requisicaoEntrada2 = new EntradaMedicamento(medicamento2, 34, DateTime.Now, funcionario1);
            EntradaMedicamento requisicaoEntrada3 = new EntradaMedicamento(medicamento3, 46, DateTime.Now, funcionario1);
            EntradaMedicamento requisicaoEntrada4 = new EntradaMedicamento(medicamento4, 58, DateTime.Now, funcionario2);

            repositorioEntradaMedicamento.Inserir(requisicaoEntrada1);
            repositorioEntradaMedicamento.Inserir(requisicaoEntrada2);
            repositorioEntradaMedicamento.Inserir(requisicaoEntrada3);
            repositorioEntradaMedicamento.Inserir(requisicaoEntrada4);

            SaidaMedicamento requisicaoSaida1 = new SaidaMedicamento(medicamento4, 8, DateTime.Now, funcionario1, paciente1);
            SaidaMedicamento requisicaoSaida2 = new SaidaMedicamento(medicamento3, 6, DateTime.Now.AddMonths(1), funcionario1, paciente2);
            SaidaMedicamento requisicaoSaida3 = new SaidaMedicamento(medicamento3, 20, DateTime.Now.AddMonths(2), funcionario2, paciente3);

            SaidaMedicamento requisicaoSaida4 = new SaidaMedicamento(medicamento4, 21, DateTime.Now, funcionario1, paciente1);
            SaidaMedicamento requisicaoSaida5 = new SaidaMedicamento(medicamento2, 3, DateTime.Now.AddMonths(1), funcionario2, paciente2);

            SaidaMedicamento requisicaoSaida6 = new SaidaMedicamento(medicamento1, 2, DateTime.Now.AddMonths(1), funcionario1, paciente4);

            repositorioSaidaMedicamento.Inserir(requisicaoSaida1);
            repositorioSaidaMedicamento.Inserir(requisicaoSaida2);
            repositorioSaidaMedicamento.Inserir(requisicaoSaida3);

            repositorioSaidaMedicamento.Inserir(requisicaoSaida4);
            repositorioSaidaMedicamento.Inserir(requisicaoSaida5);

            repositorioSaidaMedicamento.Inserir(requisicaoSaida6);

            ArrayList listaTeste = repositorioMedicamento.SelecionarMedicamentosMaisRetirados();
        }
    }
}