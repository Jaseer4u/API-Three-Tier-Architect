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

        public bool Create(LeaveType entity)
        {
            _db.LeaveType.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveType.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _db.LeaveType.ToList();
        }

        public LeaveType GetByID(int ID)
        {
            return _db.LeaveType.Find(ID);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveType.Update(entity);
            return Save();
        }
    }
}
