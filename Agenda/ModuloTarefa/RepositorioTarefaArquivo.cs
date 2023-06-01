

namespace Agenda.ModuloTarefa {
    public class RepositorioTarefaArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa {

        public RepositorioTarefaArquivo(ContextoDados contexto) : base(contexto) {
        }

        protected override List<Tarefa> ObterRegistros() {

            return contextoDados.tarefas;
        }


        public List<Tarefa> SelecionarConcluidas() {
            return ObterRegistros()
                    .Where(x => x.percentual == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes() {
            return ObterRegistros()
                    .Where(x => x.percentual < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPorPrioridade() {
            return ObterRegistros()
                   .OrderByDescending(x => x.prioridade)
                   .ToList();
        }

    }
}
