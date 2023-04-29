namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    public class Usuario : EntidadeBase
    {
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string[] Endereco { get; set; }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {

        }

    }
}
