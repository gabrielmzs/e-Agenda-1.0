using Agenda.Compartilhado;
using Agenda.ModuloContato;


namespace Agenda.ModuloCompromisso {
    public class Compromisso:EntidadeBase {

        public string assunto;
        public DateTime dia;
        public TimeSpan inicio;
        public TimeSpan fim;
        public Contato contato;
        public string tipo;
        public string local;

        public Compromisso(string assunto, DateTime dia, TimeSpan inicio, TimeSpan fim, Contato contato, string tipo, string local) {
            this.assunto = assunto;
            this.dia = dia;
            this.inicio = inicio;
            this.fim = fim;
            this.contato = contato;
            this.tipo = tipo;
            this.local = local;
        }

        public Compromisso(string assunto, DateTime dia, TimeSpan inicio, TimeSpan fim, string local, string tipo) {
            this.assunto = assunto;
            this.dia = dia;
            this.inicio = inicio;
            this.fim = fim;
            this.tipo = tipo;
            this.local = local;
        }



        public override string ToString() {
            return "Id: " + id + ", " + assunto + ". Data: " + (dia + inicio) + " Local: " + local + " Contato: " + contato.nome;
        }
    }
}
