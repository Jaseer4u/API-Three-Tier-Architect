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
    public class LeaveTypeRepo : ILeaveTypeRepo
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(LeaveType entity)
        {
            _db.LeaveType.Add(entity);
            return await Save();
        }

        public async Task<bool> Delete(int ID)
        {
            var entity = await _db.LeaveType.FindAsync(ID);
            if (entity == null)
            {
                return false;
            }
            _db.LeaveType.Remove(entity);
            return await Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveType.ToList();
        }

        public async Task<LeaveType> GetByID(int ID)
        {
            return await _db.LeaveType.FindAsync(ID);
        }

        public async Task<bool> Save()
        {
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(LeaveType entity)
        {
            _db.LeaveType.Update(entity);
            return await Save();
        }
    }
}
