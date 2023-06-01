

namespace Agenda.ModuloDespesa {
    internal class RepositorioMemoriaDespesa:RepositorioMemoriaBase<Despesa> {

        public RepositorioMemoriaDespesa(List<Despesa> despesas) {
            listaRegistros = despesas;
        }
    }
}
