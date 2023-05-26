namespace Agenda.ModuloTarefa {
    partial class TelaFiltroTarefaForm {
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.rdbTodas = new System.Windows.Forms.RadioButton();
            this.rdbPendentes = new System.Windows.Forms.RadioButton();
            this.rdbConcluidas = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(159, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 50);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Location = new System.Drawing.Point(60, 191);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 50);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Filtrar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // rdbTodas
            // 
            this.rdbTodas.AutoSize = true;
            this.rdbTodas.Location = new System.Drawing.Point(67, 26);
            this.rdbTodas.Name = "rdbTodas";
            this.rdbTodas.Size = new System.Drawing.Size(160, 19);
            this.rdbTodas.TabIndex = 24;
            this.rdbTodas.TabStop = true;
            this.rdbTodas.Text = "Visualizar Todas as Tarefas";
            this.rdbTodas.UseVisualStyleBackColor = true;
            // 
            // rdbPendentes
            // 
            this.rdbPendentes.AutoSize = true;
            this.rdbPendentes.Location = new System.Drawing.Point(67, 68);
            this.rdbPendentes.Name = "rdbPendentes";
            this.rdbPendentes.Size = new System.Drawing.Size(171, 19);
            this.rdbPendentes.TabIndex = 25;
            this.rdbPendentes.TabStop = true;
            this.rdbPendentes.Text = "Visualizar Tarefas Pendentes";
            this.rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbConcluidas
            // 
            this.rdbConcluidas.AutoSize = true;
            this.rdbConcluidas.Location = new System.Drawing.Point(67, 110);
            this.rdbConcluidas.Name = "rdbConcluidas";
            this.rdbConcluidas.Size = new System.Drawing.Size(175, 19);
            this.rdbConcluidas.TabIndex = 26;
            this.rdbConcluidas.TabStop = true;
            this.rdbConcluidas.Text = "Visualizar Tarefas Concluídas";
            this.rdbConcluidas.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 253);
            this.Controls.Add(this.rdbConcluidas);
            this.Controls.Add(this.rdbPendentes);
            this.Controls.Add(this.rdbTodas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "TelaFiltroTarefaForm";
            this.Text = "Filtro de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnConfirmar;
        private RadioButton rdbTodas;
        private RadioButton rdbPendentes;
        private RadioButton rdbConcluidas;
    }
}