﻿namespace Agenda {
    partial class TelaPrincipalForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.btnDespesaCategoria = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosMenuItem,
            this.compromissosMenuItem,
            this.tarefasMenuItem,
            this.categoriasMenuItem,
            this.despesasMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            this.contatosMenuItem.Name = "contatosMenuItem";
            this.contatosMenuItem.Size = new System.Drawing.Size(197, 22);
            this.contatosMenuItem.Text = "Contatos";
            this.contatosMenuItem.Click += new System.EventHandler(this.contatosMenuItem_Click);
            // 
            // compromissosMenuItem
            // 
            this.compromissosMenuItem.Name = "compromissosMenuItem";
            this.compromissosMenuItem.Size = new System.Drawing.Size(197, 22);
            this.compromissosMenuItem.Text = "Compromissos";
            this.compromissosMenuItem.Click += new System.EventHandler(this.compromissosMenuItem_Click);
            // 
            // tarefasMenuItem
            // 
            this.tarefasMenuItem.Name = "tarefasMenuItem";
            this.tarefasMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tarefasMenuItem.Text = "Tarefas";
            this.tarefasMenuItem.Click += new System.EventHandler(this.tarefasMenuItem_Click);
            // 
            // categoriasMenuItem
            // 
            this.categoriasMenuItem.Name = "categoriasMenuItem";
            this.categoriasMenuItem.Size = new System.Drawing.Size(197, 22);
            this.categoriasMenuItem.Text = "Categorias de Despesas";
            this.categoriasMenuItem.Click += new System.EventHandler(this.categoriasMenuItem_Click);
            // 
            // despesasMenuItem
            // 
            this.despesasMenuItem.Name = "despesasMenuItem";
            this.despesasMenuItem.Size = new System.Drawing.Size(197, 22);
            this.despesasMenuItem.Text = "Despesas";
            this.despesasMenuItem.Click += new System.EventHandler(this.despesasMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatus.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.btnFiltrar,
            this.toolStripSeparator3,
            this.btnAdicionar,
            this.toolStripSeparator2,
            this.btnConcluir,
            this.toolStripSeparator4,
            this.btnDespesaCategoria,
            this.toolStripSeparator5,
            this.labelTipoCadastro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::Agenda.Properties.Resources.add_FILL0_wght500_GRAD0_opsz40;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(44, 52);
            this.btnInserir.Text = "toolStripButton1";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::Agenda.Properties.Resources.edit_FILL0_wght500_GRAD0_opsz40;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 52);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::Agenda.Properties.Resources.delete_FILL0_wght500_GRAD0_opsz40;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(44, 52);
            this.btnExcluir.Text = "toolStripButton3";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = global::Agenda.Properties.Resources.filter_alt_FILL0_wght500_GRAD0_opsz40;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 52);
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::Agenda.Properties.Resources.library_add_FILL0_wght500_GRAD0_opsz40;
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(44, 52);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnConcluir
            // 
            this.btnConcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConcluir.Image = global::Agenda.Properties.Resources.check_box_FILL0_wght500_GRAD0_opsz40;
            this.btnConcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(44, 52);
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(99, 52);
            this.labelTipoCadastro.Text = "tipoCadastro";
            // 
            // panelRegistros
            // 
            this.panelRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 79);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(800, 349);
            this.panelRegistros.TabIndex = 3;
            // 
            // btnDespesaCategoria
            // 
            this.btnDespesaCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDespesaCategoria.Image = global::Agenda.Properties.Resources.pageview_FILL0_wght500_GRAD0_opsz48;
            this.btnDespesaCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDespesaCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDespesaCategoria.Name = "btnDespesaCategoria";
            this.btnDespesaCategoria.Size = new System.Drawing.Size(52, 52);
            this.btnDespesaCategoria.Click += new System.EventHandler(this.btnDespesaCategoria_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatus;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripButton btnAdicionar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnConcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripButton btnDespesaCategoria;
        private ToolStripSeparator toolStripSeparator5;
    }
}