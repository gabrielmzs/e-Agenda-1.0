using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloContato {
    public interface IRepositorioContato {

        void Inserir(Contato novoContato);
        void Editar(int id, Contato contato);
        void Excluir(Contato contataSelecionado);
        
        Contato SelecionarPorId(int id);
        List<Contato> SelecionarTodos();

    }
}
