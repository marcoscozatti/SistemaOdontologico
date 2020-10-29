using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EntityFramework_aulaReposicao.Model;

namespace EntityFramework_aulaReposicao.Controler
{
	class Contexto : DbContext
	{
        public Contexto() : base(@"Server=.\SQLEXPRESS; Database=BDSistemaConsultorio; Integrated Security=true;")
        {

        }

        //public DbSet<Paciente> ObjetoPaciente { get; set; }
        //public DbSet<Medico> ObjetoMedico { get; set; }
        //public DbSet<Especialidade> ObjetoEspecialidade { get; set; }
        //public DbSet<Consulta> ObjetoConsulta { get; set; }
        public DbSet<ManutUser> ObjetoManuteUser { get; set; }
    }
    //	  * 1-) enable-migrations

    //	  * 2-) Add-migration banco

    //	  * 3-) update-database

}
