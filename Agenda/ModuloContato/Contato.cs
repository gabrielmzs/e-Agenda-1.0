using Agenda.Compartilhado;

namespace Agenda.ModuloContato {
    public class Contato:EntidadeBase {
        
        public string nome;
        public string empresa;
        public string cargo;
        public string telefone;
        public string email;

        public Contato( string nome, string empresa, string telefone, string email, string cargo) {
            
            this.nome = nome;
            this.empresa = empresa;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
        }

        public override string ToString() {
            return "Id: " + id + ", " + nome + ". Empresa: " + empresa;
        }
    }

    
}
