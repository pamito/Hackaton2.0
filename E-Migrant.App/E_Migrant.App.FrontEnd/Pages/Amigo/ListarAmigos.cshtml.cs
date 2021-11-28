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
    public class ListarAmigosModel : PageModel
    {
        
        private readonly IRepositorioAmigo repositorioAmigo;
        public ListarAmigosModel(IRepositorioAmigo repositorioAmigo)
        {
            this.repositorioAmigo = repositorioAmigo;
        }
        public IEnumerable<Amigo> amigos;
        public void OnGet()
        {
            amigos = repositorioAmigo.getAllAmigo();
        }
    }
}
