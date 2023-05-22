namespace Agenda.ModuloCompromisso {
    partial class TelaCompromisso {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtPresencial = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbRemoto = new System.Windows.Forms.RadioButton();
            this.rbPresencial = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimeDia = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.comboBoxContatos = new System.Windows.Forms.ComboBox();
            this.txtRemoto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(92, 55);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(580, 27);
            this.txtAssunto.TabIndex = 0;
            // 
            // txtPresencial
            // 
            this.txtPresencial.Location = new System.Drawing.Point(184, 265);
            this.txtPresencial.Name = "txtPresencial";
            this.txtPresencial.ReadOnly = true;
            this.txtPresencial.Size = new System.Drawing.Size(435, 27);
            this.txtPresencial.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Location = new System.Drawing.Point(481, 342);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 59);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(587, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 59);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Início:";
            // 
            // rbRemoto
            // 
            this.rbRemoto.AutoSize = true;
            this.rbRemoto.Checked = true;
            this.rbRemoto.Location = new System.Drawing.Point(81, 233);
            this.rbRemoto.Name = "rbRemoto";
            this.rbRemoto.Size = new System.Drawing.Size(86, 24);
            this.rbRemoto.TabIndex = 17;
            this.rbRemoto.TabStop = true;
            this.rbRemoto.Text = "Remoto:";
            this.rbRemoto.UseVisualStyleBackColor = true;
            this.rbRemoto.CheckedChanged += new System.EventHandler(this.rbRemoto_CheckedChanged);
            // 
            // rbPresencial
            // 
            this.rbPresencial.AutoSize = true;
            this.rbPresencial.Location = new System.Drawing.Point(81, 265);
            this.rbPresencial.Name = "rbPresencial";
            this.rbPresencial.Size = new System.Drawing.Size(99, 24);
            this.rbPresencial.TabIndex = 18;
            this.rbPresencial.Text = "Presencial:";
            this.rbPresencial.UseVisualStyleBackColor = true;
            this.rbPresencial.CheckedChanged += new System.EventHandler(this.rbPresencial_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(346, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Deseja marcar um contato neste compromisso?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimeDia
            // 
            this.dateTimeDia.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDia.Location = new System.Drawing.Point(95, 108);
            this.dateTimeDia.Name = "dateTimeDia";
            this.dateTimeDia.Size = new System.Drawing.Size(153, 27);
            this.dateTimeDia.TabIndex = 20;
            this.dateTimeDia.Value = new System.DateTime(2023, 5, 19, 0, 0, 0, 0);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.CustomFormat = "HH:mm";
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(443, 108);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.ShowUpDown = true;
            this.dateTimeInicio.Size = new System.Drawing.Size(71, 27);
            this.dateTimeInicio.TabIndex = 21;
            this.dateTimeInicio.Value = new System.DateTime(2023, 5, 19, 0, 0, 0, 0);
            // 
            // dateTimeFim
            // 
            this.dateTimeFim.CustomFormat = "HH:mm";
            this.dateTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFim.Location = new System.Drawing.Point(572, 108);
            this.dateTimeFim.Name = "dateTimeFim";
            this.dateTimeFim.ShowUpDown = true;
            this.dateTimeFim.Size = new System.Drawing.Size(71, 27);
            this.dateTimeFim.TabIndex = 22;
            this.dateTimeFim.Value = new System.DateTime(2023, 5, 19, 0, 0, 0, 0);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 342);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 27);
            this.txtId.TabIndex = 23;
            this.txtId.Text = "0";
            // 
            // comboBoxContatos
            // 
            this.comboBoxContatos.Enabled = false;
            this.comboBoxContatos.FormattingEnabled = true;
            this.comboBoxContatos.Location = new System.Drawing.Point(423, 173);
            this.comboBoxContatos.Name = "comboBoxContatos";
            this.comboBoxContatos.Size = new System.Drawing.Size(238, 28);
            this.comboBoxContatos.TabIndex = 24;
            // 
            // txtRemoto
            // 
            this.txtRemoto.Location = new System.Drawing.Point(184, 232);
            this.txtRemoto.Name = "txtRemoto";
            this.txtRemoto.Size = new System.Drawing.Size(435, 27);
            this.txtRemoto.TabIndex = 25;
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 413);
            this.Controls.Add(this.txtRemoto);
            this.Controls.Add(this.comboBoxContatos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dateTimeFim);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.dateTimeDia);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbPresencial);
            this.Controls.Add(this.rbRemoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtPresencial);
            this.Controls.Add(this.txtAssunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCompromisso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Compromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAssunto;
        private TextBox txtPresencial;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbRemoto;
        private RadioButton rbPresencial;
        private CheckBox checkBox1;
        private DateTimePicker dateTimeDia;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeFim;
        private TextBox txtId;
        private ComboBox comboBoxContatos;
        private TextBox txtRemoto;
    }
}