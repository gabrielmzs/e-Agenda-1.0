using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCompromisso {
    public class RepositorioCompromisso {

        List<Compromisso> compromissos = new List<Compromisso>();
        private static int contador = 0;

        public void Inserir(Compromisso compromisso) {

            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        public List<Compromisso> SelecionarTodos() {
            return compromissos;
        }

        public void Editar(Compromisso compromisso) {

            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);
            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.dia = compromisso.dia;
            compromissoSelecionado.inicio = compromisso.fim;
            compromissoSelecionado.contato = compromisso.contato;
            compromissoSelecionado.tipo = compromisso.tipo;
            compromissoSelecionado.local = compromisso.local;

        }

        private Compromisso SelecionarPorId(int id) {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        internal void Excluir(Compromisso compromisso) {
            compromissos.Remove(compromisso);
        }
    }
}
