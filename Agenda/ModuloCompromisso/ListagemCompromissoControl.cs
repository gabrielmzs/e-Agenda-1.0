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

namespace Agenda.ModuloCompromisso {
    public partial class ListagemCompromissoControl : UserControl {
        public ListagemCompromissoControl() {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos) {

            listCompromisso.Items.Clear();

            foreach (Compromisso c in compromissos) {
                listCompromisso.Items.Add(c);
            }
        }

        public Compromisso ObterCompromissoSelecionado() {

            return (Compromisso)listCompromisso.SelectedItem;
        }
    }
}
