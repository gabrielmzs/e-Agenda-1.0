

namespace Agenda.ModuloCategorias {
    public interface IRepositorioCategoria {

        void Inserir(Categoria novoCategoria);
        void Editar(int id, Categoria categoria);
        void Excluir(Categoria categoriaSelecionada);

        Categoria SelecionarPorId(int id);
        List<Categoria> SelecionarTodos();

    }
}
