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
    public class ActualizarServicioModel : PageModel
    {
        private readonly IRepositorioServicio repositorioServicio;
        private readonly IRepositorioNesecidad repositorioNesecidad;
        public Servicio servicio { get; set; }
        public List<SelectListItem> nesecidades { get; set; }

        public int Id { get; set; }

        public ActualizarServicioModel(IRepositorioServicio repositorioServicio, IRepositorioNesecidad repositorioNesecidad)
        {
            this.repositorioServicio = repositorioServicio;
            this.repositorioNesecidad = repositorioNesecidad;
            
            nesecidades = repositorioNesecidad.getAllNesecidades().Select(
                c => new SelectListItem
                {
                    Text = c.Descripcion,
                    Value = Convert.ToString(c.Id)
                }
            ).ToList();
        }
        public void OnGet(int Id)
        {
            servicio = repositorioServicio.getServicio(Id);
        }
        public ActionResult OnPost(Servicio servicio, int Id)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    Nesecidad nesecidad = repositorioNesecidad.getNesecidad(Id);

                    servicio.Nesecidad = nesecidad;
                    repositorioServicio.editServicio(servicio);
                    
                    return RedirectToPage("./ListarServicio");
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
