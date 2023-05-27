using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCategorias {
    public  class RepositorioCategoria:RepositorioBase<Categoria> {

        public RepositorioCategoria(List<Categoria> categorias) {
            listaRegistros = categorias;
        }

    }
}
