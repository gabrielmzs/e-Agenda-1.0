using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloDespesas {
    internal class RepositorioDespesa:RepositorioBase<Despesa> {

        public RepositorioDespesa(List<Despesa> despesas) {
            listaRegistros = despesas;
        }
    }
}
