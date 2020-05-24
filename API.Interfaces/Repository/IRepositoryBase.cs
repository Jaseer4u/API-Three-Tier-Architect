using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T GetByID(int ID);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
