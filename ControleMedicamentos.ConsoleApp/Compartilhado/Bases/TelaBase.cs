using System.Collections;

namespace ControleMedicamentos.ConsoleApp.Compartilhado.Bases
{
    public abstract class TelaBase
    {

        public string nomeEntidade;
        public string sufixo;
        protected RepositorioBase repositorioBase = null;

        protected abstract EntidadeBase ObterRegistro();
        protected abstract void MostrarTabela(ArrayList registros);

        public void MostrarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.WriteLine();
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
        public void MostrarCabecalho(string titulo, string subtitulo)
        {
            Console.Clear();
            Console.WriteLine(titulo + "\n");
            Console.WriteLine(subtitulo + "\n");
        }
        public virtual void VisualizarRegistros(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
            {
                MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", $"Visualizando registros de {nomeEntidade} já cadastrados...");
            }
            ArrayList registros = repositorioBase.SelecionarTodos();
            if (registros.Count == 0)
            {
                MostrarMensagem($"Nenhum registro de {nomeEntidade} cadastrado", ConsoleColor.DarkYellow);
                return;
            }
            MostrarTabela(registros);
        }
        public virtual void InserirNovoRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", $"Inserindo um novo registro de {nomeEntidade}...");
            EntidadeBase registro = ObterRegistro();
            repositorioBase.Inserir(registro);
            MostrarMensagem($"Registro de {nomeEntidade} inserido com sucesso!", ConsoleColor.DarkGreen);
        }
        public virtual void EditarRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", $"Editando um registro de {nomeEntidade} já cadastrado...");
            VisualizarRegistros(false);
            Console.WriteLine();
            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            EntidadeBase registroAtualizado = ObterRegistro();
            repositorioBase.Editar(id, registroAtualizado);
            MostrarMensagem($"Registro de {nomeEntidade} editado com sucesso!", ConsoleColor.Green);
        }
        public virtual void ExcluirRegistro()
        {
            MostrarCabecalho($"Cadastro de {nomeEntidade}{sufixo}", "Excluindo um registro já cadastrado...");
            VisualizarRegistros(false);
            Console.WriteLine();
            Console.Write("Digite o id do registro: ");
            int id = Convert.ToInt32(Console.ReadLine());
            repositorioBase.Excluir(id);
            MostrarMensagem($"Registro de {nomeEntidade} excluído com sucesso!", ConsoleColor.Green);
        }
        public virtual int InteragirMenu()
        {
            Console.Clear();
            Console.WriteLine($"Cadastro de {nomeEntidade}{sufixo} \n");
            Console.WriteLine($"[1] - Inserir {nomeEntidade}");
            Console.WriteLine($"[2] - Visualizar {nomeEntidade}{sufixo}");
            Console.WriteLine($"[3] - Editar {nomeEntidade}{sufixo}");
            Console.WriteLine($"[4] - Excluir {nomeEntidade}{sufixo}\n");
            Console.WriteLine("[0] - Menu Inicial");
            int opcaoMenu = Convert.ToInt32(Console.ReadLine());
            return opcaoMenu;
        }
    }
}
