using System.Collections;

namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    public class RepositorioBase
    {
        protected ArrayList lista;
        protected int contadorRegistros = 0;

        public virtual ArrayList SelecionarTodos()
        {
            return lista;
        }
        public virtual EntidadeBase SelecionarPorId(int id)
        {
            EntidadeBase registroSelecionado = null;
            foreach (EntidadeBase registro in lista)
            {
                if (registro.Id == id)
                {
                    registroSelecionado = registro;
                    break;
                }
            }

            return registroSelecionado;
        }
        public virtual void Inserir(EntidadeBase registro)
        {
            contadorRegistros++;
            registro.Id = contadorRegistros;
            lista.Add(registro);
        }
        public virtual void Editar(int id, EntidadeBase registroAtualizado)
        {
            EntidadeBase registroSelecionado = SelecionarPorId(id);
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }
        public virtual void Excluir(int id)
        {
            EntidadeBase registroSelecionado = SelecionarPorId(id);
            lista.Remove(registroSelecionado);
        }
    }
}
