using System.Collections.Generic;

namespace Lista_de_Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorID(int id);

         void insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int ProximoId();
    }
}