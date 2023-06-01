
using Agenda.ModuloContato;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agenda.Compartilhado {
    public abstract class RepositorioArquivoBase <TEntidade> where TEntidade : EntidadeBase<TEntidade> {

        protected ContextoDados contextoDados;

        protected int contadorRegistros = 0;


        public RepositorioArquivoBase(ContextoDados contexto) {
            contextoDados = contexto;

            AtualizarContador();
        }


        protected abstract List<TEntidade> ObterRegistros();


        public void AtualizarContador() {
            if (ObterRegistros().Count > 0)
                contadorRegistros = ObterRegistros().Max(x => x.id);
        }

        public void Editar(int id, TEntidade registro) {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registro);

            contextoDados.GravarEmArquivoJson();
        }

        public void Excluir(TEntidade registroSelecionado) {
            ObterRegistros().Remove(registroSelecionado);

            contextoDados.GravarEmArquivoJson();
        }

        public void Inserir(TEntidade novoRegistro) {

            List<TEntidade> registros = ObterRegistros();

            contadorRegistros++;
            novoRegistro.id = contadorRegistros;
            registros.Add(novoRegistro);



            contextoDados.GravarEmArquivoJson();
        }

        public TEntidade SelecionarPorId(int id) {
            TEntidade registro = ObterRegistros().FirstOrDefault(x => x.id == id);

            return registro;
        }

        public List<TEntidade> SelecionarTodos() {
            return ObterRegistros();
        }

        
    }
}
