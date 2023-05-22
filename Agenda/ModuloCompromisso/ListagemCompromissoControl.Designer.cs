namespace Agenda.ModuloCompromisso {
    partial class ListagemCompromissoControl {
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
            this.listCompromisso = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCompromisso
            // 
            this.listCompromisso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCompromisso.FormattingEnabled = true;
            this.listCompromisso.ItemHeight = 15;
            this.listCompromisso.Location = new System.Drawing.Point(0, 0);
            this.listCompromisso.Name = "listCompromisso";
            this.listCompromisso.Size = new System.Drawing.Size(598, 511);
            this.listCompromisso.TabIndex = 0;
            // 
            // ListagemCompromissoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listCompromisso);
            this.Name = "ListagemCompromissoControl";
            this.Size = new System.Drawing.Size(598, 511);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listCompromisso;
    }
}
