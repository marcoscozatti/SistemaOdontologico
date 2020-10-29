using EntityFramework_aulaReposicao.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_aulaReposicao.Model;
using System.Data.Entity;

namespace EntityFramework_aulaReposicao.View
{
	public partial class frmManutUsuario : Form
	{
		public frmManutUsuario()
		{
			InitializeComponent();
		}

		private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var tb = new Contexto())
			{
				try
				{
				
					tb.ObjetoManuteUser.Add(new ManutUser {  Nome = txtNome.Text, Sobrenome = txtSobrenome.Text, Usuario = txtNome.Text + txtSobrenome.Text, Senha = txtSenha.Text });
					tb.SaveChanges();
					limpacampos();
					MessageBox.Show("Incluido com sucesso", "Inclusão");
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}
		}

		public void limpacampos()
		{
			txtID.Text = "";
			txtUsuario.Text = "";
			txtSenha.Text = "";
			txtUsuario.Focus();
			AtualizaGrid();
			txtUsuario.Enabled = false;
		}

		public void AtualizaGrid()
		{
			using (var tb = new Contexto())
			{
				dgManutUsuario.DataSource = null;
				dgManutUsuario.DataSource = tb.ObjetoManuteUser.ToList();
			}
		}

		private void frmManutUsuario_Load(object sender, EventArgs e)
		{
			AtualizaGrid();
			txtUsuario.Enabled = false;
		}

		private void altrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var tb = new Contexto())
			{
				try
				{
					var objeto = tb.ObjetoManuteUser.Find(Convert.ToInt32(txtID.Text));
					objeto.Usuario = txtUsuario.Text;
					objeto.Senha = txtSenha.Text;


					tb.Entry(objeto).State = EntityState.Modified;
					tb.SaveChanges();
					MessageBox.Show("Alteração realizada com sucesso", "Alteração");
					limpacampos();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}
		}

		private void dgManutUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtID.Text = dgManutUsuario.CurrentRow.Cells[0].Value.ToString();
			txtNome.Text = dgManutUsuario.CurrentRow.Cells[1].Value.ToString();
			txtSobrenome.Text = dgManutUsuario.CurrentRow.Cells[2].Value.ToString();
			txtUsuario.Text = dgManutUsuario.CurrentRow.Cells[3].Value.ToString();
			txtSenha.Text = dgManutUsuario.CurrentRow.Cells[4].Value.ToString();
		}

		private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var tb = new Contexto())
			{
				try
				{
					var objeto = tb.ObjetoManuteUser.Find(Convert.ToInt32(txtID.Text));
					tb.ObjetoManuteUser.Remove(objeto);
					tb.SaveChanges();
					MessageBox.Show("Exlcuido com sucesso", "Exclusão");
					limpacampos();
					
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}
		}


	}
}


