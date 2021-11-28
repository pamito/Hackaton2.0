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
    public class EliminarAmigoModel : PageModel
    {
        private readonly IRepositorioAmigo repositorioAmigo;
        public Amigo amigo {get; set; }

        public EliminarAmigoModel(IRepositorioAmigo repositorioAmigo){
            this.repositorioAmigo = repositorioAmigo;
        }
        public void OnGet(int Id)
        {
            amigo = repositorioAmigo.getAmigo(Id);
        }

        public IActionResult OnPost(Amigo amigo){
            try{
                repositorioAmigo.removeAmigo(amigo.Id);
                return RedirectToPage("./ListarAmigos");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
