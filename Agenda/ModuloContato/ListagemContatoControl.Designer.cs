namespace Agenda.ModuloContato {
    partial class ListagemContatoControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listContato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listContato
            // 
            this.listContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContato.FormattingEnabled = true;
            this.listContato.ItemHeight = 15;
            this.listContato.Location = new System.Drawing.Point(0, 0);
            this.listContato.Name = "listContato";
            this.listContato.Size = new System.Drawing.Size(547, 437);
            this.listContato.TabIndex = 0;
            // 
            // ListagemContatoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listContato);
            this.Name = "ListagemContatoControl";
            this.Size = new System.Drawing.Size(547, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listContato;
    }
}
