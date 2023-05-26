using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.ModuloTarefa {
    public partial class TabelaTarefaControl : UserControl {
        public TabelaTarefaControl() {
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
                    HeaderText= "Título"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "prioridade",
                    HeaderText= "Prioridade"
                },
                new DataGridViewTextBoxColumn(){
                    Name = "percentual",
                    HeaderText= "% Concluído"
                },


            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tarefa> tarefas) {

            grid.Rows.Clear();

            foreach (Tarefa t in tarefas) {
                grid.Rows.Add(t.id, t.titulo, t.prioridade, t.percentual);
            }

        }

        public int ObterIdSelecionado() {
            
            int id = 0;
            try 
            {
               id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            } 
            catch 
            {
                id = -1;
            }

            return id;


        }
    }
}
