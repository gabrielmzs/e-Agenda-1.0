using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCategorias {
    public  class RepositorioMemoriaCategoria:RepositorioMemoriaBase<Categoria>, IRepositorioCategoria {

        public RepositorioMemoriaCategoria(List<Categoria> categorias) {
            listaRegistros = categorias;
        }

    }
}
