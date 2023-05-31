using Agenda.Compartilhado;

namespace Agenda.ModuloContato {

    [Serializable]
    public class Contato:EntidadeBase<Contato> {
        
        public string nome { get; set; }
        public string empresa;
        public string cargo;
        public string telefone;
        public string email;

        public Contato() {

            
        }

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

        public override void AtualizarInformacoes(Contato registroAtualizado) {
            nome = registroAtualizado.nome;
            email = registroAtualizado.email;
            telefone = registroAtualizado.telefone;
            cargo = registroAtualizado.cargo;
            empresa = registroAtualizado.empresa;
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }
    }

    
}
