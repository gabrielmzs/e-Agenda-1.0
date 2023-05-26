
namespace Agenda.ModuloTarefa {
    public partial class TelaCadastroItensTarefaForm : Form {

        

        public TelaCadastroItensTarefaForm(Tarefa tarefa) {
            InitializeComponent();
            this.ConfigurarDialog();
            

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa) {
            txtId.Text = tarefa.id.ToString();
            txtTitulo.Text = tarefa.titulo;

            foreach (ItemTarefa item in tarefa.itens) {
                listItens.Items.Add(item);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            if(txtDescricao.Text != "") {

            string descricao = txtDescricao.Text;

            ItemTarefa itemTarefa = new ItemTarefa (descricao);

            listItens.Items.Add (itemTarefa);

            txtDescricao.Text = "";
            } 
            else {
                MessageBox.Show("A descrição do item não pode ficar vazia.","Inclusão de itens",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        public List<ItemTarefa> ObterItensCadastrados() {
            return listItens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}
