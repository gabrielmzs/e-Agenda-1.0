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

namespace Agenda.ModuloTarefa {
    public partial class ListagemTarefaControl : UserControl {
        public ListagemTarefaControl() {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas) {

            listTarefas.Items.Clear();

            foreach (Tarefa t in tarefas) {
                listTarefas.Items.Add(t);
            }
        }

        public Tarefa ObterTarefaSelecionada() {

            return (Tarefa)listTarefas.SelectedItem;
        }
    }
}
