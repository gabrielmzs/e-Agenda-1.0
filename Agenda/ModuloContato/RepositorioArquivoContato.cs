

namespace Agenda.ModuloContato {
    public class RepositorioArquivoContato:RepositorioArquivoBase<Contato> ,IRepositorioContato {

        public RepositorioArquivoContato(ContextoDados  contexto):base(contexto) {
        }

        protected override List<Contato> ObterRegistros() {

            return contextoDados.contatos;
        }
    }
}
