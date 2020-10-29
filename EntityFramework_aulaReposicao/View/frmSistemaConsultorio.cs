using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_aulaReposicao.View
{
	public partial class frmSistemaConsultorio : Form
	{
		public frmSistemaConsultorio()
		{
			InitializeComponent();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void manutençãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmManutUsuario manutusr = new frmManutUsuario();
			manutusr.Show();
		}
	}
}
