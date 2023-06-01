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

namespace Agenda.ModuloCategoria {
    public partial class TelaCategoriaForm : Form {
        public TelaCategoriaForm() {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        internal void ConfigurarTela(Categoria categoria) {
            txtId.Text = categoria.id.ToString();
            txtTitulo.Text = categoria.titulo;
        }

        internal Categoria ObterCategoria() {
            string titulo = txtTitulo.Text;
            int id = Convert.ToInt32(txtId.Text);

            Categoria categoria = new Categoria(titulo);
            categoria.id = id;

            return categoria;

        }
    }
}
