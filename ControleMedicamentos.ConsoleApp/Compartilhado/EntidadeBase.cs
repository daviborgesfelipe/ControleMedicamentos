namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public abstract void AtualizarInformacoes(EntidadeBase registroAtualizado);
    }
}
