using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCategorias {
    public class RepositorioArquivoCategoria : RepositorioArquivoBase<Categoria>, IRepositorioCategoria {

        private const string NOME_ARQUIVO_CATEGORIA = "categorias.bin";


        public RepositorioArquivoCategoria() {
            if (File.Exists(NOME_ARQUIVO_CATEGORIA))
                CarregarRegistrosDoArquivo(NOME_ARQUIVO_CATEGORIA);
        }

        public void Editar(int id, Categoria categoria) {
            Categoria categoriaSelecionado = SelecionarPorId(id);

            categoriaSelecionado.AtualizarInformacoes(categoria);

            GravarTarefasEmArquivo(NOME_ARQUIVO_CATEGORIA);
        }

        public void Excluir(Categoria categoriaSelecionado) {
            listaRegistros.Remove(categoriaSelecionado);

            GravarTarefasEmArquivo(NOME_ARQUIVO_CATEGORIA);
        }

        public void Inserir(Categoria novoCategoria) {
            contadorRegistros++;
            novoCategoria.id = contadorRegistros;
            listaRegistros.Add(novoCategoria);

            GravarTarefasEmArquivo(NOME_ARQUIVO_CATEGORIA);
        }

        public Categoria SelecionarPorId(int id) {
            Categoria categoria = listaRegistros.FirstOrDefault(x => x.id == id);

            return categoria;
        }

        public List<Categoria> SelecionarTodos() {
            return listaRegistros;
        }
    }
}
