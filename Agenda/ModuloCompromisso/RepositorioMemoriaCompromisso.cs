
namespace Agenda.ModuloCompromisso {
    public class RepositorioMemoriaCompromisso:RepositorioMemoriaBase<Compromisso> ,IRepositorioCompromisso{

        public RepositorioMemoriaCompromisso(List<Compromisso> compromissos) {
            listaRegistros = compromissos;
        }
    }
}
