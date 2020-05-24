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
        T GetByID(int ID);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
       
    }
    
}
