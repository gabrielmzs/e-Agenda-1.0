

namespace Agenda.ModuloTarefa {
    public class RepositorioTarefaMemoria : RepositorioMemoriaBase<Tarefa>, IRepositorioTarefa {

        public RepositorioTarefaMemoria(List<Tarefa> tarefas) {
            listaRegistros = tarefas;
        }

        public List<Tarefa>? SelecionarPendentes() {
            return listaRegistros
                .Where(x => x.percentual < 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa>? SelecionarConcluidas() {
            return listaRegistros
                .Where(x=> x.percentual == 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa> SelecionarPorPrioridade() {
            return listaRegistros.OrderByDescending(x => x.prioridade).ToList();
        }

        
    }
}
