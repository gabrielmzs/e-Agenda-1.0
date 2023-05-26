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

namespace Agenda.ModuloContato {
    public partial class TabelaContatoControl : UserControl {
        public TabelaContatoControl() {
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
                    Name = "nome",
                    HeaderText= "Nome"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "empresa",
                    HeaderText= "Empresa"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "cargo",
                    HeaderText= "Cargo"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "email",
                    HeaderText= "e-mail"
                },


            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Contato> contatos) {

            grid.Rows.Clear();

            foreach (Contato c in contatos) {
                grid.Rows.Add(c.id, c.nome,c.empresa,c.cargo,c.email);
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
