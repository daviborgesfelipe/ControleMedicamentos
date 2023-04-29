using ControleMedicamentos.ConsoleApp.Compartilhado.Interfaces;

namespace ControleMedicamentos.ConsoleApp.Compartilhado.Bases
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public virtual void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
        }
    }
}
