using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Interfaces.Domain
{

    public interface IEntityBase<T> where T : class
    {
        ICollection<T> FindAll();
        Task<T> GetByID(int ID);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int ID);

    }
    
}
