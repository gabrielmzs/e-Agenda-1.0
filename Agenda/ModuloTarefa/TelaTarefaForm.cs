using Agenda.Compartilhado;

namespace Agenda.ModuloTarefa {
    public partial class TelaTarefaForm : Form {
        public TelaTarefaForm() {

            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();

        }

        public Tarefa ObterTarefa() {

            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridade.SelectedItem;
            DateTime data = txtDataCriacao.Value;

            return new Tarefa(id, titulo, prioridade,data);
        }

        public void CarregarPrioridades() {

            PrioridadeTarefaEnum[] prioridades = Enum.GetValues<PrioridadeTarefaEnum>();

            foreach (PrioridadeTarefaEnum p in prioridades) {

                cmbPrioridade.Items.Add(p);
            }
        }

        internal void ConfigurarTela(Tarefa tarefa) {
            
            txtId.Text = tarefa.id.ToString();
            txtTitulo.Text = tarefa.titulo;
            cmbPrioridade.SelectedItem = tarefa.prioridade;
            txtDataCriacao.Value = tarefa.dataCriacao;

            if(tarefa.id > 0)  txtDataCriacao.Enabled = false; 
        }
    }
}
