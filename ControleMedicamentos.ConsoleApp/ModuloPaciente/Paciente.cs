using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;
using ControleMedicamentos.ConsoleApp.Compartilhado.Interfaces;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    public class Paciente : EntidadeBase
    {
        public string nome;
        public string cartaoSus;

        public Paciente(string nome, string cartaoSUS)
        {
            this.nome = nome;
            this.cartaoSus = cartaoSUS;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Paciente pacienteAtualizado = (Paciente)registroAtualizado;

            this.nome = pacienteAtualizado.nome;
            this.cartaoSus = pacienteAtualizado.cartaoSus;
        }
    }
}
