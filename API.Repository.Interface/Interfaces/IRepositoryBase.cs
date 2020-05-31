using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Repository.Interface.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        Task<T> GetByID(int ID);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int ID);
        Task<bool> Save();
    }
}
