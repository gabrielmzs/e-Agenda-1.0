

using System.Runtime.Serialization.Formatters.Binary;

namespace Agenda.ModuloTarefa {
    internal class RepositorioTarefaArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa {


        private const string NOME_ARQUIVO_TAREFAS = "tarefas.bin";

      

        public RepositorioTarefaArquivo() {
            if (File.Exists(NOME_ARQUIVO_TAREFAS))
                CarregarRegistrosDoArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public void Editar(int id, Tarefa tarefa) {
            Tarefa tarefaSelecionada = SelecionarPorId(id);

            tarefaSelecionada.AtualizarInformacoes(tarefa);

            GravarTarefasEmArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public void Excluir(Tarefa tarefaSelecionada) {
            listaRegistros.Remove(tarefaSelecionada);

            GravarTarefasEmArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public void Inserir(Tarefa novaTarefa) {
            contadorRegistros++;
            novaTarefa.id = contadorRegistros;
            listaRegistros.Add(novaTarefa);

            GravarTarefasEmArquivo(NOME_ARQUIVO_TAREFAS);
        }

        public List<Tarefa> SelecionarConcluidas() {
            return listaRegistros
                    .Where(x => x.percentual == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes() {
            return listaRegistros
                    .Where(x => x.percentual < 100)
                    .ToList();
        }

        public Tarefa SelecionarPorId(int id) {
            Tarefa tarefa = listaRegistros.FirstOrDefault(x => x.id == id);

            return tarefa;
        }

        public List<Tarefa> SelecionarPorPrioridade() {
            return listaRegistros
                   .OrderByDescending(x => x.prioridade)
                   .ToList();
        }

        public List<Tarefa> SelecionarTodos() {
            return listaRegistros;
        }

        //private void CarregarTarefasDoArquivo() {
        //    BinaryFormatter serializador = new BinaryFormatter();

        //    byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO_TAREFAS);

        //    MemoryStream tarefaStream = new MemoryStream(tarefaEmBytes);

        //    tarefas = (List<Tarefa>)serializador.Deserialize(tarefaStream);

        //    AtualizarContador();
        //}

        //private void AtualizarContador() {
        //    contador = tarefas.Max(x => x.id);
        //}

        //private void GravarTarefasEmArquivo() {
        //    BinaryFormatter serializador = new BinaryFormatter();

        //    MemoryStream tarefaStream = new MemoryStream();

        //    serializador.Serialize(tarefaStream, tarefas);

        //    byte[] tarefasEmBytes = tarefaStream.ToArray();

        //    File.WriteAllBytes(NOME_ARQUIVO_TAREFAS, tarefasEmBytes);
        //}
    }
}
