using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T> //Substitui o T aqui por Serie na SerieRepositorio
    {
        List<T> Lista();

        T RetornaPorId(int id); 

        void Insere(T entidade);  

        void Exclui(int id); 

        void Atualiza(int id, T entidade);

        int ProximoId();
         
    }
}