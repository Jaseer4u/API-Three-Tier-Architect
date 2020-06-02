using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.CommonDTO.ModelEF;
using API.Domain.Interfaces.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers.V1
{
    [Route("api/v1/UserRegistration")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationEntity _Entity;


        public UserRegistrationController(IUserRegistrationEntity Entity)
        {
            _Entity = Entity;

        }

        // GET: api/UserRegistration
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<UserRegistration> Get()
        {
            return _Entity.FindAll();
        }

        // GET: api/UserRegistration/5
        [HttpGet]
        [Route("GetById{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var UserRegistration = await _Entity.GetByID(id);

            if (UserRegistration == null)
            {
                return NotFound();
            }

            return Ok(UserRegistration);
        }

        // POST: api/UserRegistration
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save([FromBody] UserRegistration UserRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _Entity.Create(UserRegistration);
            return Ok(UserRegistration);
        }

        // PUT: api/UserRegistration/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(await _Entity.Delete(id));
        }
    }
}
