using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCompromisso {
    public interface IRepositorioCompromisso {
        void Inserir(Compromisso novoCompromisso);
        void Editar(int id, Compromisso compromisso);
        void Excluir(Compromisso compromissoSelecionado);

        Compromisso SelecionarPorId(int id);
        List<Compromisso> SelecionarTodos();
    }
}
