

namespace Agenda.ModuloCategorias {

    [Serializable]
    public class Categoria : EntidadeBase<Categoria> {

        public string titulo;

        public Categoria(string titulo) {
            this.titulo = titulo;
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado) {
            titulo = registroAtualizado.titulo;
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return titulo;
        }

        public override bool Equals(object? obj) {
            return obj is Categoria categoria &&
                   id == categoria.id &&
                   titulo == categoria.titulo;
        }
    }
}
