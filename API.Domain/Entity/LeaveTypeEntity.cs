using API.CommonDTO.ModelEF;
using API.Domain.Interfaces.Domain;
using API.Repository.Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entity
{
    public class LeaveTypeEntity : ILeaveTypeEntity
    {
        private readonly ILeaveTypeRepo _repo;
        public LeaveTypeEntity(ILeaveTypeRepo repo)
        {
            _repo = repo;
        }
        public bool Create(LeaveType entity)
        {
           return _repo.Create(entity);
        }

        public bool Delete(LeaveType entity)
        {
            return _repo.Create(entity);
        }

        public ICollection<LeaveType> FindAll()
        {
            return _repo.FindAll();
        }

        public LeaveType GetByID(int ID)
        {
            return _repo.GetByID(ID);
        }
        public bool Update(LeaveType entity)
        {
            return _repo.Update(entity);
        }
    }
}
