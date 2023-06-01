
using Agenda.ModuloContato;

namespace Agenda.ModuloCategoria {
    public class RepositorioArquivoCategoria : RepositorioArquivoBase<Categoria>, IRepositorioCategoria {

        public RepositorioArquivoCategoria(ContextoDados contexto) : base(contexto) {
        }

        protected override List<Categoria> ObterRegistros() {

            return contextoDados.categorias;
        }
    }
}
