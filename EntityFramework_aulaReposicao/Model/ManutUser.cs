using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_aulaReposicao.Model
{
	class ManutUser
	{
		[Key]
		public int IdUsuario { get; set; }
		public string Nome { get; set; }
		public string Sobrenome  { get; set; }
		public string Usuario { get; set; }
		public string Senha { get; set; }
	}
}
