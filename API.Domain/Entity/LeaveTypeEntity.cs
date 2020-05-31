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
        public async Task<bool> Create(LeaveType entity)
        {
           return await _repo.Create(entity);
        }

        public async Task<bool> Delete(int ID)
        {
            return await _repo.Delete(ID);
        }

        public  ICollection<LeaveType> FindAll()
        {
            return  _repo.FindAll();
        }

        public async Task<LeaveType> GetByID(int ID)
        {
            return await _repo.GetByID(ID);
        }
        public async Task<bool> Update(LeaveType entity)
        {
            return await _repo.Update(entity);
        }
    }
}
