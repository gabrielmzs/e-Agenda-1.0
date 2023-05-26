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

namespace Agenda.ModuloCompromisso {
    public partial class TelaCompromisso : Form {

        private Compromisso compromisso;

        List<Contato> contatos;
        public TelaCompromisso(List<Contato> contatos) {
            InitializeComponent();
            this.contatos = contatos;
            PreencherComboBox();
            
        }

        public void PreencherComboBox() {
            foreach (Contato c in contatos) {

                comboBoxContatos.Items.Add(c);
            }
        }

        private void rbRemoto_CheckedChanged(object sender, EventArgs e) {
            
            txtRemoto.Enabled = true;
            txtPresencial.Enabled = false;

        }

        private void rbPresencial_CheckedChanged(object sender, EventArgs e) {

            txtPresencial.Enabled = true;
            txtRemoto.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                comboBoxContatos.Enabled = true;
            }
            else comboBoxContatos.Enabled = false;
        }

        
        public Compromisso ObterCompromisso() {

            
            int id = Convert.ToInt32(txtId.Text);
            TipoLocalEnum tipo = TipoLocalEnum.Presencial;
            string local = "";


            if (rbPresencial.Checked) {
                 tipo = TipoLocalEnum.Presencial;
                 local = txtPresencial.Text;
            }

            if (rbRemoto.Checked) {
                 tipo = TipoLocalEnum.Local;
                 local = txtRemoto.Text;
            }


            string assunto = txtAssunto.Text;
            DateTime dia = dateTimeDia.Value.Date;
            TimeSpan inicio = dateTimeInicio.Value.TimeOfDay;
            TimeSpan fim = dateTimeFim.Value.TimeOfDay;

            if (checkBox1.Checked) {

                Contato contato = (Contato)comboBoxContatos.SelectedItem;
                compromisso = new Compromisso(assunto, dia, inicio, fim, contato, local, tipo);

            } else compromisso = new Compromisso(assunto, dia, inicio, fim, local, tipo);

            compromisso.id = id;
            return compromisso;

            
        }

        internal void ConfigurarTela(Compromisso compromisso) {
            txtId.Text = compromisso.id.ToString();
            txtAssunto.Text = compromisso.assunto;
            dateTimeDia.Value = compromisso.dia;
            dateTimeInicio.Value = DateTime.Now.Date.Add(compromisso.inicio);
            dateTimeFim.Value = DateTime.Now.Date.Add(compromisso.fim);
            dateTimeDia.Value = compromisso.dia;

            if (compromisso.contato != null) {
                checkBox1.Checked = true;
                comboBoxContatos.SelectedItem = compromisso.contato;
            }

            if (compromisso.tipo == TipoLocalEnum.Presencial) {
                rbPresencial.Checked = true;
                txtPresencial.Text = compromisso.local;
            } else {
                rbRemoto.Checked = true;
                txtRemoto.Text = compromisso.local;
            }


        }
    }
}
