using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.ModuloCategoria {
    public partial class TabelaCategoriaControl : UserControl {
        public TabelaCategoriaControl() {
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
                    Name = "titulo",
                    HeaderText= "Categoria"
                },

            };

            grid.Columns.AddRange(colunas);
        }

        internal void AtualizarRegistros(List<Categoria> categorias) {
            grid.Rows.Clear();

            foreach (Categoria c in categorias) {
                grid.Rows.Add(c.id, c.titulo);
            }
        }

        internal int ObterIdSelecionado() {
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
