

namespace Agenda.ModuloTarefa {
    public class RepositorioTarefa : RepositorioBase<Tarefa> {

        public RepositorioTarefa(List<Tarefa> tarefas) {
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
