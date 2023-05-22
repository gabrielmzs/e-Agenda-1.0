using Agenda.Compartilhado;
using Agenda.ModuloCompromisso;

namespace Agenda.ModuloContato {
    public class ControladorContato : ControladorBase {
        
        private RepositorioContato repositorioContato;
        private RepositorioCompromisso repositorioCompromisso;
        private ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorioContato) {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Contato"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato Existente"; } }

        public override string ToolTipEditar { get { return "Editar Contato Existente"; } }

        public override string LabelTipoCadastro { get { return "Cadastro de Contatos"; } }

        public override void Inserir() {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida== DialogResult.OK) {
                Contato contato = telaContato.Contato;
                repositorioContato.Inserir(contato);
                CarregarContatos();
            }
        }

        public override void Editar() {
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Contato contato = telaContato.Contato;
                repositorioContato.Editar(contato);
                CarregarContatos();
            }
        }



        private void CarregarContatos() {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem() {

            if(listagemContato == null) {
                listagemContato = new ListagemContatoControl();
            }

            CarregarContatos();

            return listagemContato;
        }

        public override void Excluir() {
            
            Contato contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o contato {contato.nome} ?", "Exclusão de Contatos", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                
                repositorioContato.Excluir(contato);
                CarregarContatos();
            }
        }
    }


}
