using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussnies
{
    /// <summary>
    /// DECLARA LOS METODOS DEL CRUD 
    /// </summary>
    /// <typeparam name="T">REQUEST</typeparam>
    /// <typeparam name="Y">RESPONSE</typeparam>
    public interface ICRUDBussnies<T, Y> : IDisposable
    {
        List<Y> GetAll();
        Y GetById(int id);
        Y Create(T entity);
        Y Update(T entity);
        int Delete(int id);
        int DeleteMultipleItems(List<T> lista);
        List<Y> CreateMultiple(List<T> lista);
        List<Y> UpdateMultiple(List<T> lista);
        GenericFilterResponse<Y> GetByFilter(GenericFilterRequest request);

    }
}