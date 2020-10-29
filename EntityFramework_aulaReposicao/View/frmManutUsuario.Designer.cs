namespace EntityFramework_aulaReposicao.View
{
	partial class frmManutUsuario
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
			this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.altrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSobrenome = new System.Windows.Forms.TextBox();
			this.lblSobrenome = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblID = new System.Windows.Forms.Label();
			this.dgManutUsuario = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgManutUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.altrarToolStripMenuItem,
            this.excluirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(471, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inserirToolStripMenuItem
			// 
			this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
			this.inserirToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
			this.inserirToolStripMenuItem.Text = "Inserir";
			this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
			// 
			// altrarToolStripMenuItem
			// 
			this.altrarToolStripMenuItem.Name = "altrarToolStripMenuItem";
			this.altrarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
			this.altrarToolStripMenuItem.Text = "Alterar";
			this.altrarToolStripMenuItem.Click += new System.EventHandler(this.altrarToolStripMenuItem_Click);
			// 
			// excluirToolStripMenuItem
			// 
			this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
			this.excluirToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
			this.excluirToolStripMenuItem.Text = "Excluir";
			this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSobrenome);
			this.groupBox1.Controls.Add(this.lblSobrenome);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.lblNome);
			this.groupBox1.Controls.Add(this.txtSenha);
			this.groupBox1.Controls.Add(this.lblSenha);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.lblUsuario);
			this.groupBox1.Controls.Add(this.lblID);
			this.groupBox1.Location = new System.Drawing.Point(12, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(436, 235);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Manutenção";
			// 
			// txtSobrenome
			// 
			this.txtSobrenome.Location = new System.Drawing.Point(95, 106);
			this.txtSobrenome.Name = "txtSobrenome";
			this.txtSobrenome.Size = new System.Drawing.Size(304, 22);
			this.txtSobrenome.TabIndex = 9;
			// 
			// lblSobrenome
			// 
			this.lblSobrenome.AutoSize = true;
			this.lblSobrenome.Location = new System.Drawing.Point(5, 111);
			this.lblSobrenome.Name = "lblSobrenome";
			this.lblSobrenome.Size = new System.Drawing.Size(81, 17);
			this.lblSobrenome.TabIndex = 8;
			this.lblSobrenome.Text = "Sobrenome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(95, 66);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(304, 22);
			this.txtNome.TabIndex = 7;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(33, 71);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(45, 17);
			this.lblNome.TabIndex = 6;
			this.lblNome.Text = "Nome";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(95, 191);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(304, 22);
			this.txtSenha.TabIndex = 5;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(29, 196);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(49, 17);
			this.lblSenha.TabIndex = 4;
			this.lblSenha.Text = "Senha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(95, 151);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(304, 22);
			this.txtUsuario.TabIndex = 3;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(95, 29);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 22);
			this.txtID.TabIndex = 2;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(29, 156);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(57, 17);
			this.lblUsuario.TabIndex = 1;
			this.lblUsuario.Text = "Usuário";
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(57, 32);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 17);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID";
			// 
			// dgManutUsuario
			// 
			this.dgManutUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgManutUsuario.Location = new System.Drawing.Point(12, 286);
			this.dgManutUsuario.Name = "dgManutUsuario";
			this.dgManutUsuario.RowHeadersWidth = 51;
			this.dgManutUsuario.RowTemplate.Height = 24;
			this.dgManutUsuario.Size = new System.Drawing.Size(436, 209);
			this.dgManutUsuario.TabIndex = 2;
			this.dgManutUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManutUsuario_CellContentClick);
			// 
			// frmManutUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 503);
			this.Controls.Add(this.dgManutUsuario);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmManutUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manutenção de Usuários";
			this.Load += new System.EventHandler(this.frmManutUsuario_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgManutUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem altrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.DataGridView dgManutUsuario;
		private System.Windows.Forms.TextBox txtSobrenome;
		private System.Windows.Forms.Label lblSobrenome;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
	}
}