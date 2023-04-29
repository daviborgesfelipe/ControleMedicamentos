using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMedicamentos.ConsoleApp.Compartilhado.Bases;

namespace ControleMedicamentos.ConsoleApp.Compartilhado.Interfaces
{
    public interface IRepositorioBase
    {
        ArrayList SelecionarTodos();
        EntidadeBase SelecionarPorId(int id);
        void Inserir(EntidadeBase registro);
        void Editar(int id, EntidadeBase registroAtualizado);
        void Excluir(int id);
    }
}
