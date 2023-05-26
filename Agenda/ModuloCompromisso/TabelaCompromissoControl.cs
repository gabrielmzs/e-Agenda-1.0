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

namespace Agenda.ModuloCompromisso {
    public partial class TabelaCompromissoControl : UserControl {
        public TabelaCompromissoControl() {
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
                    Name = "assunto",
                    HeaderText= "Assunto"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "dia",
                    HeaderText= "Data"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "inicio",
                    HeaderText= "Horário de Término"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "local",
                    HeaderText= "Local"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "contato",
                    HeaderText= "Contato"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Compromisso> compromissos) {

            grid.Rows.Clear();

            foreach (Compromisso c in compromissos) {
                if (c.contato != null) 
                    grid.Rows.Add(c.id, c.assunto, c.dia + c.inicio, c.fim, c.local, c.contato.nome);

                else 
                    grid.Rows.Add(c.id, c.assunto, c.dia + c.inicio, c.fim, c.local);
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
