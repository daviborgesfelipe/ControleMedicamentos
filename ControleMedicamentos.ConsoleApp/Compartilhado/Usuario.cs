namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal class Usuario : EntidadeBase
    {
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string[] Endereco { get; set; }
    }
}
