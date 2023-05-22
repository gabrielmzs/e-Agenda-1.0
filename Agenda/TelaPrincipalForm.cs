using Agenda.Compartilhado;
using Agenda.ModuloCompromisso;
using Agenda.ModuloContato;

namespace Agenda {
    public partial class TelaPrincipalForm : Form {

        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();
        public TelaPrincipalForm() {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e) {

            controlador = new ControladorContato(repositorioContato);
            ConfigurarTelaPrincipal(controlador);
            
            
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e) {

            controlador = new ControladorCompromisso(repositorioCompromisso,repositorioContato);
            ConfigurarTelaPrincipal(controlador);

        }

        private void btnInserir_Click(object sender, EventArgs e) {

            controlador.Inserir();
            
        }

        private void ConfigurarListagem(ControladorBase controladorBase) {

            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);

        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase) {

            labelTipoCadastro.Text = controladorBase.LabelTipoCadastro;
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }


        private void ConfigurarToolTips(ControladorBase controlador) {

            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void btnEditar_Click(object sender, EventArgs e) {

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            controlador.Excluir();
        }
    }
}