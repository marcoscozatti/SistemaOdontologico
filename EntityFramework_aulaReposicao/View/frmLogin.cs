using EntityFramework_aulaReposicao.Controler;
using EntityFramework_aulaReposicao.Model;
using EntityFramework_aulaReposicao.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_aulaReposicao
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

			//conexao via bd
			using (var tb = new Contexto())
			{
				try
				{  //lambda
					var objusr = tb.ObjetoManuteUser.Where(x => x.Usuario == txtUsuario.Text).FirstOrDefault();
					var objpass = tb.ObjetoManuteUser.Where(a => a.Senha == txtSenha.Text).FirstOrDefault();

					if (objusr != null && objpass != null)
					{
						this.Hide();
						Form f = new frmSistemaConsultorio();
						f.Closed += (s, args) => this.Close();
						f.Show();
					}
					else
					{
						MessageBox.Show("Usuário ou senha não confere");
					}

				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}
			}


			//using (var tb = new Contexto())
			//{

			//	// select campos from tabela
			//	var usr = from ob in tb.ObjetoManuteUser
			//			  where ob.usuario == txtUsuario.Text && ob.senha == txtSenha.Text
			//			  select ob.usuario;
			//	var pass = from ps in tb.ObjetoManuteUser
			//			   where ps.usuario == txtUsuario.Text && ps.senha == txtSenha.Text
			//			   select ps.senha;
			//	if (txtUsuario.Text == "" || txtSenha.Text == "")
			//	{
			//		MessageBox.Show("Campos em branco");
			//	}
			//	else
			//	{
			//		if (usr != null && pass != null)
			//		{
			//			this.Hide();
			//			Form f = new frmSistemaConsultorio();
			//			f.Closed += (s, args) => this.Close();
			//			f.Show();
			//		}
			//		else
			//		{
			//			MessageBox.Show("Erro: ", "Atenção!");
			//		}
			//	}

			//}



		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
