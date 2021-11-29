using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.FrontEnd
{
    public class DetalleMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante repositorioMigrante;
        public Migrante migrante { get; set; }

        public DetalleMigranteModel(IRepositorioMigrante repositorioMigrante){
            this.repositorioMigrante = repositorioMigrante;
        }
        public void OnGet(int Id)
        {
            migrante = repositorioMigrante.getMigrante(Id);
        }
    }
}
