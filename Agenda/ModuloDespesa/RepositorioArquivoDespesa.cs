

using Agenda.ModuloContato;

namespace Agenda.ModuloDespesa {
    public class RepositorioArquivoDespesa : RepositorioArquivoBase<Despesa>, IRepositorioDespesa {

        public RepositorioArquivoDespesa(ContextoDados contexto) : base(contexto) {
        }

        protected override List<Despesa> ObterRegistros() {

            return contextoDados.despesas;
        }

    }
}
