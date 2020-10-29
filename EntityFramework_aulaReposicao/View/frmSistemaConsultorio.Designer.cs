namespace EntityFramework_aulaReposicao.View
{
	partial class frmSistemaConsultorio
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrosBásicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.especialidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manutençãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1314, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sistemaToolStripMenuItem
			// 
			this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem,
            this.consultaToolStripMenuItem});
			this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.sistemaToolStripMenuItem.Text = "Sistema";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// manutençãoToolStripMenuItem
			// 
			this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosBásicosToolStripMenuItem});
			this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
			this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.manutençãoToolStripMenuItem.Text = "Manutenção";
			// 
			// cadastrosBásicosToolStripMenuItem
			// 
			this.cadastrosBásicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.médicoToolStripMenuItem,
            this.especialidadeToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.manutençãoDeUsuáriosToolStripMenuItem});
			this.cadastrosBásicosToolStripMenuItem.Name = "cadastrosBásicosToolStripMenuItem";
			this.cadastrosBásicosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.cadastrosBásicosToolStripMenuItem.Text = "Cadastros Básicos";
			// 
			// clienteToolStripMenuItem
			// 
			this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
			this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.clienteToolStripMenuItem.Text = "Cliente";
			// 
			// médicoToolStripMenuItem
			// 
			this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
			this.médicoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.médicoToolStripMenuItem.Text = "Médico";
			// 
			// especialidadeToolStripMenuItem
			// 
			this.especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
			this.especialidadeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.especialidadeToolStripMenuItem.Text = "Especialidade";
			// 
			// pacienteToolStripMenuItem
			// 
			this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
			this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
			this.pacienteToolStripMenuItem.Text = "Paciente";
			// 
			// manutençãoDeUsuáriosToolStripMenuItem
			// 
			this.manutençãoDeUsuáriosToolStripMenuItem.Name = "manutençãoDeUsuáriosToolStripMenuItem";
			this.manutençãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
			this.manutençãoDeUsuáriosToolStripMenuItem.Text = "Manutenção de Usuários";
			this.manutençãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeUsuáriosToolStripMenuItem_Click);
			// 
			// consultaToolStripMenuItem
			// 
			this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
			this.consultaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.consultaToolStripMenuItem.Text = "Consulta";
			// 
			// frmSistemaConsultorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 685);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmSistemaConsultorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema Consultorio ";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrosBásicosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem especialidadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manutençãoDeUsuáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
	}
}