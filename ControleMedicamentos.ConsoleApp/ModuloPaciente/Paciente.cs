using ControleMedicamentos.ConsoleApp.Compartilhado;
namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class Paciente : Usuario
    {
        public int Cpf { get; set; }
        public string CartaoSus { get; set; }

        public Paciente(string nome, string cartaoSUS)
        {
            Nome = nome;
            CartaoSus = cartaoSUS;
        }

    }
}
