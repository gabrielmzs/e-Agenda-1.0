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
    public partial class TabelaDespesaControl : UserControl {
        public TabelaDespesaControl() {
            InitializeComponent();
            ConfigurarColunas();
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        private void ConfigurarColunas() {
            DataGridViewColumn[] colunas = new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn(){
                    Name = "id",
                    HeaderText= "ID",
                },
                new DataGridViewTextBoxColumn(){
                    Name = "descricao",
                    HeaderText= "Descrição"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "data",
                    HeaderText= "Data"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "valor",
                    HeaderText= "Valor"
                },


            };

            grid.Columns.AddRange(colunas);
        }

        internal void AtualizarRegistros(List<Despesa> despesas) {
            grid.Rows.Clear();

            foreach (Despesa d in despesas) {
                grid.Rows.Add(d.id, d.descricao, d.data, d.valor);
            }
        }

        public int ObterIdSelecionado() {

            int id = 0;
            try {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            } catch {
                id = -1;
            }

            return id;


        }
    }
}
