
using Agenda.ModuloContato;

namespace Agenda.ModuloCompromisso {
    public class RepositorioArquivoCompromisso : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso {

        public RepositorioArquivoCompromisso(ContextoDados contexto) : base(contexto) {
        }

        protected override List<Compromisso> ObterRegistros() {

            return contextoDados.compromissos;
        }
    }
}
