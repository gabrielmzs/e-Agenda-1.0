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
    public partial class TelaContatoForm : Form {

        private Contato contato;
        public TelaContatoForm() {
            InitializeComponent();
        }

        public Contato Contato {

            set 
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtCargo.Text = value.cargo;
                txtEmail.Text = value.email;
                txtEmpresa.Text= value.empresa;
                txtTelefone.Text= value.telefone;

            }

            get 
            {
                return contato;
            }
        }  

        private void btnConfirmar_Click(object sender, EventArgs e) {

            while(txtNome.Text == "") {
                
            }

            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, empresa, telefone, email, cargo);

            if(txtId.Text != "0") 
                contato.id = Convert.ToInt32(txtId.Text);

        }
    }
}
