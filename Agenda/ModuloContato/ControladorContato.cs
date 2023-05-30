using Agenda.Compartilhado;
using Agenda.ModuloCompromisso;
using Agenda.ModuloTarefa;

namespace Agenda.ModuloContato {
    public class ControladorContato : ControladorBase {
        
        private IRepositorioContato repositorioContato;
       
        private TabelaContatoControl tabelaContato;

        public ControladorContato(IRepositorioContato repositorioContato) {
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
            telaContato.Contato = ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Contato contato = telaContato.Contato;
                repositorioContato.Editar(contato.id, contato);
                CarregarContatos();
            }
        }



        private void CarregarContatos() {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            tabelaContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem() {

            if(tabelaContato == null) {
                tabelaContato = new TabelaContatoControl();
            }

            CarregarContatos();

            return tabelaContato;
        }

        public override void Excluir() {
            
            Contato contato = ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o contato {contato.nome} ?", "Exclusão de Contatos", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {
                
                repositorioContato.Excluir(contato);
                CarregarContatos();
            }
        }

        private Contato ObterContatoSelecionado() {
            int id = tabelaContato.ObterIdSelecionado();
            return repositorioContato.SelecionarPorId(id);
        }
    }


}
