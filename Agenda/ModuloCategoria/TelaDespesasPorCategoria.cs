using Agenda.ModuloDespesa;

namespace Agenda.ModuloCategoria {
    public partial class TelaDespesasPorCategoria : Form {
        public TelaDespesasPorCategoria() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        internal void ConfigurarTela(Categoria categoriaSelecionada, List<Despesa> listaDespesa) {
            labelTipoCategoria.Text = categoriaSelecionada.titulo;

            foreach (Despesa d in listaDespesa) {
                if(d.listaCategorias.Contains(categoriaSelecionada))
                    listBoxDespesas.Items.Add(d);
                }
            }
        }
    }

