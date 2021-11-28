using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.FrontEnd
{
    public class CrearAmigoModel : PageModel
    {
        private readonly IRepositorioAmigo repositorioAmigo;
        private readonly IRepositorioMigrante repositorioMigrante;
        public Amigo amigo { get; set; }
        public List<SelectListItem> migrantes { get; set; }

        public int Id { get; set; }
        public int IdA { get; set; }

        public CrearAmigoModel(IRepositorioAmigo repositorioAmigo, IRepositorioMigrante repositorioMigrante)
        {
            this.repositorioAmigo = repositorioAmigo;
            this.repositorioMigrante = repositorioMigrante;
            amigo = new Amigo();
            migrantes = repositorioMigrante.getAllMigrante().Select(
                c => new SelectListItem
                {
                    Text = c.Numero_Documento,
                    Value = Convert.ToString(c.Id)
                }
            ).ToList();
        }
        public void OnGet(int Id)
        {
            amigo = repositorioAmigo.getAmigo(Id);
        }
        public ActionResult OnPost(Amigo amigo, int Id, int IdA)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    Migrante migrante = repositorioMigrante.getMigrante(Id);

                    amigo.Migrante = migrante;
                                        
                    migrante = repositorioMigrante.getMigrante(IdA);

                    amigo.MigranteA = migrante;
                    repositorioAmigo.addAmigo(amigo);
                    
                    return RedirectToPage("./ListarAmigos");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
