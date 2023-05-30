
using Agenda.ModuloCategorias;
using Agenda.ModuloCompromisso;
using Agenda.ModuloContato;
using Agenda.ModuloDespesas;
using Agenda.ModuloTarefa;

namespace Agenda {
    public partial class TelaPrincipalForm : Form {

        private ControladorBase controlador;
        private IRepositorioContato repositorioContato = new RepositorioArquivoContato();
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioArquivoCompromisso();
        
        private IRepositorioCategoria repositorioCategoria = new RepositorioArquivoCategoria();
        private IRepositorioDespesa repositorioDespesa = new RepositorioArquivoDespesa();

        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaArquivo();
        public TelaPrincipalForm() {
            InitializeComponent();

            //PopularRepositorios();
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


        //private void PopularRepositorios() {
        //    Contato robson = new Contato("Robson", "Google", "49 9 9293-3913", "robson@mail.com", "Desenvolvedor");
        //    Contato joao = new Contato("João", "Klabin", "49 9 9433-4132", "joao@mail.com", "Analista Qualidade");
        //    Contato maria = new Contato("Maria", "Delegacia", "49 9 923-5213", "maria@mail.com", "Delegada");
        //    Contato ruth = new Contato("Ruth", "Padaria", "49 9 9593-9023", "ruth@mail.com", "Confeiteira");
        //    Contato clovis = new Contato("Clóvis", "Mil Serras", "49 9 9293-0913", "clovis@mail.com", "Gerente");

        //    repositorioContato.Inserir(robson);
        //    repositorioContato.Inserir(joao);
        //    repositorioContato.Inserir(maria);
        //    repositorioContato.Inserir(ruth);
        //    repositorioContato.Inserir(clovis);

        //    Compromisso c01 = new Compromisso("Entrevista - Robson", new DateTime(2023, 5, 21), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), robson, "Midilages", TipoLocalEnum.Presencial);
        //    Compromisso c02 = new Compromisso("Entrevista - João", new DateTime(2023, 5, 22), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), joao, "Midilages", TipoLocalEnum.Presencial);
        //    Compromisso c03 = new Compromisso("Entrevista - Maria", new DateTime(2023, 5, 23), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), maria, "Midilages", TipoLocalEnum.Presencial);
        //    Compromisso c04 = new Compromisso("Entrevista - Ruth", new DateTime(2023, 5, 24), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), ruth, "Midilages", TipoLocalEnum.Presencial);
        //    Compromisso c05 = new Compromisso("Entrevista - Clóvis", new DateTime(2023, 5, 25), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), clovis, "Midilages", TipoLocalEnum.Presencial);

        //    repositorioCompromisso.Inserir(c01);
        //    repositorioCompromisso.Inserir(c02);
        //    repositorioCompromisso.Inserir(c03);
        //    repositorioCompromisso.Inserir(c04);
        //    repositorioCompromisso.Inserir(c05);


        //    Tarefa t1 = new Tarefa(1, "Preparar Apresentação 1", PrioridadeTarefaEnum.Alta, DateTime.Now);

        //    t1.AdicionarItem(new ItemTarefa("a"));
        //    t1.AdicionarItem(new ItemTarefa("b"));
        //    t1.AdicionarItem(new ItemTarefa("c"));

        //    Tarefa t2 = new Tarefa(1, "Preparar Apresentação 2 ", PrioridadeTarefaEnum.Alta, DateTime.Now);

        //    t2.AdicionarItem(new ItemTarefa("a"));
        //    t2.AdicionarItem(new ItemTarefa("b"));
        //    t2.AdicionarItem(new ItemTarefa("c"));


        //    Tarefa t3 = new Tarefa(1, "Preparar Apresentação 3 ", PrioridadeTarefaEnum.Baixa, DateTime.Now);

        //    t3.AdicionarItem(new ItemTarefa("a"));
        //    t3.AdicionarItem(new ItemTarefa("b"));
        //    t3.AdicionarItem(new ItemTarefa("c"));

        //    Tarefa t4 = new Tarefa(1, "Preparar Apresentação 4 ", PrioridadeTarefaEnum.Alta, DateTime.Now);

        //    t4.AdicionarItem(new ItemTarefa("a"));
        //    t4.AdicionarItem(new ItemTarefa("b"));
        //    t4.AdicionarItem(new ItemTarefa("c"));

        //    Tarefa t5 = new Tarefa(1, "Preparar Apresentação 5", PrioridadeTarefaEnum.Normal, DateTime.Now);

        //    t5.AdicionarItem(new ItemTarefa("a"));
        //    t5.AdicionarItem(new ItemTarefa("b"));
        //    t5.AdicionarItem(new ItemTarefa("c"));

        //    Tarefa t6 = new Tarefa(1, "Preparar Apresentação 6", PrioridadeTarefaEnum.Baixa, DateTime.Now);

        //    t6.AdicionarItem(new ItemTarefa("a"));
        //    t6.AdicionarItem(new ItemTarefa("b"));
        //    t6.AdicionarItem(new ItemTarefa("c"));

        //    repositorioTarefa.Inserir(t1);
        //    repositorioTarefa.Inserir(t2);
        //    repositorioTarefa.Inserir(t3);
        //    repositorioTarefa.Inserir(t4);
        //    repositorioTarefa.Inserir(t5);
        //    repositorioTarefa.Inserir(t6);

        //    Categoria c1 = new Categoria("Mercado");
        //    Categoria c2 = new Categoria("Farmácia");
        //    Categoria c3 = new Categoria("Faculdade");
        //    Categoria c4 = new Categoria("Boteco");
        //    Categoria c5 = new Categoria("Gastos da Casa");

        //    repositorioCategoria.Inserir(c1);
        //    repositorioCategoria.Inserir(c2);
        //    repositorioCategoria.Inserir(c3);
        //    repositorioCategoria.Inserir(c4);
        //    repositorioCategoria.Inserir(c5);

        //    List<Categoria> list1 = new List<Categoria>();
        //    list1.Add(c2);
        //    list1.Add(c3);
        //    list1.Add(c5);

        //    List<Categoria> list2 = new List<Categoria>();
        //    list2.Add(c4);
        //    list2.Add(c3);

        //    List<Categoria> list3 = new List<Categoria>();
        //    list3.Add(c2);
        //    list3.Add(c1);

        //    Despesa despesa1 = new Despesa(1, "Festa", 500, new DateTime(2023, 5, 21), PagamentoEnum.Pix, list1);
        //    Despesa despesa2 = new Despesa(1, "Boletos", 500, new DateTime(2023, 5, 21), PagamentoEnum.Cartão, list2);
        //    Despesa despesa3 = new Despesa(1, "Conta", 500, new DateTime(2023, 5, 21), PagamentoEnum.Dinheiro, list3);

        //    repositorioDespesa.Inserir(despesa1);
        //    repositorioDespesa.Inserir(despesa2);
        //    repositorioDespesa.Inserir(despesa3);
        //}

    }
}