using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloContato {
    public class RepositorioMemoriaContato:RepositorioMemoriaBase<Contato> {

        public RepositorioMemoriaContato(List<Contato> contatos) {
            listaRegistros = contatos;
        }      
    }
}
