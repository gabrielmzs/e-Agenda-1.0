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
    public partial class TelaFiltroTarefaForm : Form {
        public TelaFiltroTarefaForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public StatusEnum ObterFiltroTarefa() {
            if (rdbConcluidas.Checked == true)  return StatusEnum.Concluidas;
            else if (rdbPendentes.Checked == true)  return StatusEnum.Pendentes;
            else return StatusEnum.Todos;

        }
    }
}
