using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Persistencia
{
    public class RepositorioAmigo : IRepositorioAmigo
    {
        private readonly AppContext _contexto;
        
        public RepositorioAmigo(AppContext contexto)
        {
            this._contexto = contexto;
        }
        public Amigo addAmigo(Amigo amigo)
        {
            Amigo newAmigo = _contexto.Add(amigo).Entity;
            _contexto.SaveChanges();
            return newAmigo;
        }

        public Amigo editAmigo(Amigo amigo)
        {
            Amigo AmigoAEditar = _contexto.Amigos.Include("Migrante").FirstOrDefault(c=> c.Id == amigo.Id);
            if(AmigoAEditar != null)
            {
                AmigoAEditar.Migrante= amigo.Migrante;
                               
                AmigoAEditar.AmigoOFamiliar = amigo.AmigoOFamiliar;
                _contexto.SaveChanges();

                AmigoAEditar.MigranteA= amigo.MigranteA;

            }
            return AmigoAEditar;
        }

        public IEnumerable<Amigo> getAllAmigo()
        {
           return _contexto.Amigos.Include("Migrante");
        }


        public Amigo getAmigo(int Id)
        {
             Amigo Amigo = _contexto.Amigos.Include("Migrante").FirstOrDefault(x => x.Id == Id);
             return Amigo;
        }

        public void removeAmigo(int Id)
        {
         
            Amigo amigo = _contexto.Amigos.FirstOrDefault(c => c.Id == Id);
            if(amigo != null){
                _contexto.Amigos.Remove(amigo);
                _contexto.SaveChanges();
             }
            
        }

       
    }
}