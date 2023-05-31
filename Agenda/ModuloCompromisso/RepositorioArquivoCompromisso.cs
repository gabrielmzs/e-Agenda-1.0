using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCompromisso {
    public class RepositorioArquivoCompromisso : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso {


        private const string NOME_ARQUIVO_CONTATOS = "compromisso.bin";
        Compromisso compromisso= new Compromisso();



        public RepositorioArquivoCompromisso() {
            if (File.Exists(NOME_ARQUIVO_CONTATOS))
                CarregarRegistrosDoArquivo(compromisso);
        }

        //public void Editar(int id, Compromisso compromisso) {
        //    Compromisso compromissoSelecionado = SelecionarPorId(id);

        //    compromissoSelecionado.AtualizarInformacoes(compromisso);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_CONTATOS);
        //}

        //public void Excluir(Compromisso compromissoSelecionado) {
        //    listaRegistros.Remove(compromissoSelecionado);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_CONTATOS);
        //}

        //public void Inserir(Compromisso novoCompromisso) {
        //    contadorRegistros++;
        //    novoCompromisso.id = contadorRegistros;
        //    listaRegistros.Add(novoCompromisso);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_CONTATOS);
        //}

        //public Compromisso SelecionarPorId(int id) {

        //    Compromisso compromisso = listaRegistros.FirstOrDefault(x => x.id == id);

        //    return compromisso;
        //}

        //public List<Compromisso> SelecionarTodos() {
        //    return listaRegistros;
        //}
    }
}
