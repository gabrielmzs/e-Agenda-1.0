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

                comboBoxContatos.Items.Add(c.nome);
            }
        }

        public Compromisso Compromisso {

            set {
                txtAssunto.Text = value.assunto;
                dateTimeDia.Text = value.dia.ToString();
                dateTimeInicio.Text = value.inicio.ToString();
                dateTimeFim.Text = value.fim.ToString();
                txtPresencial.Text = value.local;
                
            }

            get {
                return compromisso;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {

            string tipo = "0";
            string local = "0";

            if(rbPresencial.Checked) {
                tipo = "Presencial";
                local = txtPresencial.Text;
            }

            if (rbRemoto.Checked) {
                tipo = "Remoto";
                local = txtRemoto.Text;
            }


            string assunto = txtAssunto.Text;
            DateTime dia = dateTimeDia.Value.Date;
            TimeSpan inicio = dateTimeInicio.Value.TimeOfDay;
            TimeSpan fim = dateTimeFim.Value.TimeOfDay;
         
            if (checkBox1.Checked) {
                string nomeContato = comboBoxContatos.Text;

                Contato contato = SelecionarPorNome(nomeContato);
                compromisso = new Compromisso(assunto, dia, inicio, fim,contato, tipo, local);
            }
            else compromisso = new Compromisso(assunto, dia, inicio, fim, local, tipo); 

            if (txtId.Text != "0")
                compromisso.id = Convert.ToInt32(txtId.Text);
        }


        private void label2_Click(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void rbRemoto_CheckedChanged(object sender, EventArgs e) {
            
            txtRemoto.ReadOnly = false;
            txtPresencial.ReadOnly = true;

        }

        private void rbPresencial_CheckedChanged(object sender, EventArgs e) {

            txtPresencial.ReadOnly = false;
            txtRemoto.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                comboBoxContatos.Enabled = true;
            }
            else comboBoxContatos.Enabled = false;
        }

        private Contato SelecionarPorNome(string nome) {
            return contatos.FirstOrDefault(x => x.nome == nome);
        }
    }
}
