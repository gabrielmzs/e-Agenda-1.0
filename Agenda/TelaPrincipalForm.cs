using Agenda.Compartilhado;
using Agenda.ModuloCompromisso;
using Agenda.ModuloContato;
using Agenda.ModuloTarefa;

namespace Agenda {
    public partial class TelaPrincipalForm : Form {

        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());
        private RepositorioTarefa repositorioTarefa = new RepositorioTarefa(new List<Tarefa>());
        public TelaPrincipalForm() {
            InitializeComponent();

            PopularRepositorios();
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


        private void PopularRepositorios() {
            Contato gabriel = new Contato("Gabriel", "Google", "49 9 9293-3913", "gabriel@mail.com", "Desenvolvedor");
            Contato joao = new Contato("João", "Klabin", "49 9 9433-4132", "joao@mail.com", "Analista Qualidade");
            Contato maria = new Contato("Maria", "Delegacia", "49 9 923-5213", "maria@mail.com", "Delegada");
            Contato ruth = new Contato("Ruth", "Padaria", "49 9 9593-9023", "ruth@mail.com", "Confeiteira");
            Contato clovis = new Contato("Clóvis", "Mil Serras", "49 9 9293-0913", "clovis@mail.com", "Gerente");

            repositorioContato.Inserir(gabriel);
            repositorioContato.Inserir(joao);
            repositorioContato.Inserir(maria);
            repositorioContato.Inserir(ruth);
            repositorioContato.Inserir(clovis);

            Compromisso c01 = new Compromisso("Entrevista - Gabriel", new DateTime(2023, 5, 21), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), gabriel, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c02 = new Compromisso("Entrevista - João", new DateTime(2023, 5, 22), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), joao, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c03 = new Compromisso("Entrevista - Maria", new DateTime(2023, 5, 23), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), maria, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c04 = new Compromisso("Entrevista - Ruth", new DateTime(2023, 5, 24), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), ruth, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c05 = new Compromisso("Entrevista - Clóvis", new DateTime(2023, 5, 25), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), clovis, "Midilages", TipoLocalEnum.Presencial);

            repositorioCompromisso.Inserir(c01);
            repositorioCompromisso.Inserir(c02);
            repositorioCompromisso.Inserir(c03);
            repositorioCompromisso.Inserir(c04);
            repositorioCompromisso.Inserir(c05);

        }

    }
}