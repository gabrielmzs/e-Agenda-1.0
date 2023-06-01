
using Agenda.ModuloCategoria;
using Agenda.ModuloCompromisso;
using Agenda.ModuloContato;
using Agenda.ModuloDespesa;
using Agenda.ModuloTarefa;

namespace Agenda {
    public partial class TelaPrincipalForm : Form {

        private ControladorBase controlador;

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioContato repositorioContato = new RepositorioArquivoContato(contextoDados);
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioArquivoCompromisso(contextoDados);
        
        private IRepositorioCategoria repositorioCategoria = new RepositorioArquivoCategoria(contextoDados);
        private IRepositorioDespesa repositorioDespesa = new RepositorioArquivoDespesa(contextoDados);

        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaArquivo(contextoDados);
    
        
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
        private void tarefasMenuItem_Click(object sender, EventArgs e) {

            controlador = new ControladorTarefa(repositorioTarefa);
            ConfigurarTelaPrincipal(controlador);

        }
        private void categoriasMenuItem_Click(object sender, EventArgs e) {
            controlador = new ControladorCategoria(repositorioCategoria,repositorioDespesa);
            ConfigurarTelaPrincipal(controlador);
        }

        private void despesasMenuItem_Click(object sender, EventArgs e) {
            controlador = new ControladorDespesa(repositorioDespesa,repositorioCategoria);
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnInserir_Click(object sender, EventArgs e) {

            controlador.Inserir();
            
        }
        private void btnEditar_Click(object sender, EventArgs e) {

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            controlador.Excluir();
        }
        private void btnFiltrar_Click(object sender, EventArgs e) {
            controlador.Filtrar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            controlador.Adicionar();
        }
        private void btnConcluir_Click(object sender, EventArgs e) {
            controlador.Concluir();
        }
        private void btnDespesaCategoria_Click(object sender, EventArgs e) {
            controlador.DespesasPorCategoria();
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
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionar.ToolTipText = controlador.ToolTipAdicionar;
            btnConcluir.ToolTipText = controlador.ToolTipConcluir;
            btnDespesaCategoria.ToolTipText = controlador.ToolTipDespesasCategoria;

            btnInserir.Enabled = controlador.inserirHabilitado;
            btnEditar.Enabled = controlador.editarHabilitado;
            btnExcluir.Enabled = controlador.excluirHabilitado;
            btnFiltrar.Enabled = controlador.filtrarHabilitado;
            btnAdicionar.Enabled = controlador.adicionarHabilitado;
            btnConcluir.Enabled = controlador.concluirHabilitado;
            btnDespesaCategoria.Enabled = controlador.DespesasCategoriaHabilitado;

        }


        
    }
}