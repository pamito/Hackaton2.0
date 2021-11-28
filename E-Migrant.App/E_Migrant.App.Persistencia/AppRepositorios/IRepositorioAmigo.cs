using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioAmigo
    {
        //Consultar todos los Amigos
        IEnumerable<Amigo> getAllAmigo();
        //Añadir Amigo
        Amigo addAmigo(Amigo Amigo);
        //Editar Amigo
        Amigo editAmigo(Amigo Amigo);
        //Eliminar Amigo
        void removeAmigo(int Id);

        Amigo getAmigo(int Id);
    }
}