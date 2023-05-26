
namespace Agenda.ModuloCompromisso {
    public class RepositorioCompromisso:RepositorioBase<Compromisso>{

        public RepositorioCompromisso(List<Compromisso> compromissos) {
            listaRegistros = compromissos;
        }
    }
}
