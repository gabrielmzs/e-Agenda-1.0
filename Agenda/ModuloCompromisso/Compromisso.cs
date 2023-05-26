
using Agenda.ModuloContato;


namespace Agenda.ModuloCompromisso {
    public class Compromisso:EntidadeBase<Compromisso> {

        public string assunto;
        public DateTime dia;
        public TimeSpan inicio;
        public TimeSpan fim;
        public Contato contato;
        public string local;
        public TipoLocalEnum tipo;

        public Compromisso(string assunto, DateTime dia, TimeSpan inicio, TimeSpan fim, Contato contato, string local, TipoLocalEnum tipo) {
            this.assunto = assunto;
            this.dia = dia;
            this.inicio = inicio;
            this.fim = fim;
            this.contato = contato;
            this.tipo = tipo;
            this.local = local;
        }

        public Compromisso(string assunto, DateTime dia, TimeSpan inicio, TimeSpan fim, string local, TipoLocalEnum tipo) {
            this.assunto = assunto;
            this.dia = dia;
            this.inicio = inicio;
            this.fim = fim;
            this.tipo = tipo;
            this.local = local;
        }



        public override string ToString() {

            if(contato != null) return "Id: " + id + ", " + assunto + ". Data: " + (dia + inicio) + " Local: " + local + " Contato: " + contato.nome;
            else return "Id: " + id + ", " + assunto + ". Data: " + (dia + inicio) + " Local: " + local ;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado) {
            id = registroAtualizado.id;
            assunto = registroAtualizado.assunto;
            dia = registroAtualizado.dia;
            inicio = registroAtualizado.inicio;
            fim = registroAtualizado.fim;
            contato = registroAtualizado.contato;
            tipo = registroAtualizado.tipo;
            local = registroAtualizado.local;
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }
    }
}
