using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloContato {
    public class RepositorioContato:RepositorioBase<Contato> {

        public RepositorioContato(List<Contato> contatos) {
            listaRegistros = contatos;
        }      
    }
}
