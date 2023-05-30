
using Agenda.ModuloContato;

namespace Agenda.ModuloCompromisso {
    public class ControladorCompromisso : ControladorBase {

        private IRepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl tabelaCompromisso;
        private IRepositorioContato repositorioContato;

        public ControladorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato) {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo Compromisso";
        public override string ToolTipExcluir => "Excluir Compromisso Existente"; 
        public override string ToolTipEditar => "Editar Compromisso Existente";
        public override string ToolTipFiltrar => "Filtrar Compromissos "; 
        public override string LabelTipoCadastro => "Cadastro de Compromissos";

        public override bool filtrarHabilitado => true;


        public override void Inserir() {

            TelaCompromisso telaCompromisso = new TelaCompromisso(repositorioContato.SelecionarTodos());
            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Compromisso compromisso = telaCompromisso.ObterCompromisso();
                repositorioCompromisso.Inserir(compromisso);
                CarregarCompromissos();
            }
        }
        public override void Editar() {

            Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

            if (compromissoSelecionado == null) {
                MessageBox.Show("Nenhum Compromisso Selecionado!", "Editar Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCompromisso telaCompromisso = new TelaCompromisso(repositorioContato.SelecionarTodos());

            telaCompromisso.ConfigurarTela(compromissoSelecionado);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();
                repositorioCompromisso.Editar(compromisso.id,compromisso);
                CarregarCompromissos();
            }
        }

        public override void Excluir() {
            Compromisso compromisso = ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o compromisso selecionado?", "Exclusão de Compromisso",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {

                repositorioCompromisso.Excluir(compromisso);
                CarregarCompromissos();
            }
        }


        public override UserControl ObterListagem() {
            if (tabelaCompromisso == null) {
                tabelaCompromisso = new TabelaCompromissoControl();
            }

            CarregarCompromissos();

            return tabelaCompromisso;
        }

        private void CarregarCompromissos() {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
            tabelaCompromisso.AtualizarRegistros(compromissos);
        }


        private Compromisso ObterCompromissoSelecionado() {
            int id = tabelaCompromisso.ObterIdSelecionado();
            return repositorioCompromisso.SelecionarPorId(id);
        }
    }
}
