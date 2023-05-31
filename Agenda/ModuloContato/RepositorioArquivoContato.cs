﻿

namespace Agenda.ModuloContato {
    public class RepositorioArquivoContato:RepositorioArquivoBase<Contato> ,IRepositorioContato {

        private const string NOME_ARQUIVO_CONTATOS = "contatos.bin";
        Contato contato = new Contato();

        public RepositorioArquivoContato() {
            if (File.Exists(NOME_ARQUIVO_CONTATOS))
                CarregarRegistrosDoArquivo(contato);
        }

        //public void Editar(int id, Contato contato) {
        //    Contato contatoSelecionado = SelecionarPorId(id);

        //    contatoSelecionado.AtualizarInformacoes(contato);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_CONTATOS);
        //}

        //public void Excluir(Contato contatoSelecionado) {
        //    listaRegistros.Remove(contatoSelecionado);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_CONTATOS);
        //}

        //public void Inserir(Contato novoContato) {
        //    contadorRegistros++;
        //    novoContato.id = contadorRegistros;
        //    listaRegistros.Add(novoContato);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_CONTATOS);
        //}

        //public Contato SelecionarPorId(int id) {
        //    Contato contato = listaRegistros.FirstOrDefault(x => x.id == id);

        //    return contato;
        //}

        //public List<Contato> SelecionarTodos() {
        //    return listaRegistros;
        //}
    }
}
