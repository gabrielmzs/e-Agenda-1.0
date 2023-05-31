using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloDespesas {
    internal class RepositorioArquivoDespesa : RepositorioArquivoBase<Despesa>, IRepositorioDespesa {


        private const string NOME_ARQUIVO_DESPESAS = "despesas.bin";
        Despesa despesa = new Despesa();


        public RepositorioArquivoDespesa() {
            if (File.Exists(NOME_ARQUIVO_DESPESAS))
                CarregarRegistrosDoArquivo(despesa);
        }

        //public void Editar(int id, Despesa despesa) {
        //    Despesa despesaSelecionada = SelecionarPorId(id);

        //    despesaSelecionada.AtualizarInformacoes(despesa);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        //}

        //public void Excluir(Despesa despesaSelecionada) {
        //    listaRegistros.Remove(despesaSelecionada);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        //}

        //public void Inserir(Despesa novaDespesa) {
        //    contadorRegistros++;
        //    novaDespesa.id = contadorRegistros;
        //    listaRegistros.Add(novaDespesa);

        //    GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        //}

        //public Despesa SelecionarPorId(int id) {
        //    Despesa despesa = listaRegistros.FirstOrDefault(x => x.id == id);

        //    return despesa;
        //}

        //public List<Despesa> SelecionarTodos() {
        //    return listaRegistros;
        //}
    }
}
