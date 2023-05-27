using Agenda.ModuloCategorias;
using Agenda.ModuloContato;
using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.ModuloDespesas {
    public partial class TelaDespesaForm : Form {

        List<Categoria> categorias;
        public TelaDespesaForm(List<Categoria> categorias) {
            InitializeComponent();
            this.ConfigurarDialog();
            this.categorias = categorias;
            PreencherComboBox();
            PreencherListBox();
        }

        public void PreencherComboBox() {

             cmbPagamento.Items.Add(PagamentoEnum.Cheque);
             cmbPagamento.Items.Add(PagamentoEnum.Cartão);
             cmbPagamento.Items.Add(PagamentoEnum.Dinheiro);
             cmbPagamento.Items.Add(PagamentoEnum.Pix);

        }

        public Despesa ObterDespesa() {

            int id = Convert.ToInt32(txtId.Text);
            string descricao = txtDescricao.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            PagamentoEnum pagamento = (PagamentoEnum)cmbPagamento.SelectedItem;
            DateTime data = txtData.Value;
            List<Categoria> listCategorias = ObterItensMarcados();

            return new Despesa(id,descricao,valor,data,pagamento,listCategorias);
        }

        public void PreencherListBox() {
            foreach (Categoria c in categorias) {
                listBoxCategorias.Items.Add(c);

            }
        }

        public List<Categoria> ObterItensMarcados() {
            return listBoxCategorias.CheckedItems.Cast<Categoria>().ToList();
        }

        internal void ConfigurarTela(Despesa despesa) {
            txtId.Text = despesa.id.ToString();
            txtDescricao.Text = despesa.descricao;
            txtValor.Text= despesa.valor.ToString();
            cmbPagamento.SelectedItem = despesa.pagamento;
            txtData.Value = despesa.data;

            int i = 0;

            for(int j= 0; j < listBoxCategorias.Items.Count; j++) {

                var categoria = (Categoria)listBoxCategorias.Items[j];
                if (despesa.listaCategorias.Contains(categoria))
                    listBoxCategorias.SetItemChecked(i, true);

                i++;
            }


        }
    }
}
