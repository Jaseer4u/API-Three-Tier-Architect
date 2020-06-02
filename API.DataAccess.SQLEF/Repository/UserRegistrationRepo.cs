using API.CommonDTO.ModelEF;
using API.DataAccess.SQLEF.Data;
using API.Repository.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataAccess.SQLEF.Repository
{
    public class UserRegistrationRepo : IUserRegistrationRepo
    {
        private readonly ApplicationDbContext _db;

        public UserRegistrationRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(UserRegistration entity)
        {
            _db.UserRegistrations.Add(entity);
            return await Save();
        }

        public async Task<bool> Delete(int ID)
        {
            var entity = await _db.UserRegistrations.FindAsync(ID);
            if (entity == null)
            {
                return false;
            }
            _db.UserRegistrations.Remove(entity);
            return await Save();
        }

        public ICollection<UserRegistration> FindAll()
        {
            return _db.UserRegistrations.ToList();
        }

        public async Task<UserRegistration> GetByID(int ID)
        {
            return await _db.UserRegistrations.FindAsync(ID);
        }

        public async Task<bool> Save()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(UserRegistration entity)
        {
            _db.UserRegistrations.Update(entity);
            return await Save();
        }
    }
}
