using API.CommonDTO.ModelEF;
using API.Domain.Interfaces.Domain;
using API.Repository.Interface.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Domain.Entity
{
    public class UserRegistrationEntity : IUserRegistrationEntity
    {
        private readonly IUserRegistrationRepo _repo;
        public UserRegistrationEntity(IUserRegistrationRepo repo)
        {
            _repo = repo;
        }
        public async Task<bool> Create(UserRegistration entity)
        {
            return await _repo.Create(entity);
        }

        public async Task<bool> Delete(int ID)
        {
            return await _repo.Delete(ID);
        }

        public ICollection<UserRegistration> FindAll()
        {
            return _repo.FindAll();
        }

        public async Task<UserRegistration> GetByID(int ID)
        {
            return await _repo.GetByID(ID);
        }
        public async Task<bool> Update(UserRegistration entity)
        {
            return await _repo.Update(entity);
        }
    }
}