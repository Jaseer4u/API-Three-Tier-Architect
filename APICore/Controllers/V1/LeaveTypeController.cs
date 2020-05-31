using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.CommonDTO.ModelEF;
using API.Domain.Interfaces.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;


namespace APICore.Controllers.V1
{
    [Route("api/v1/LeaveType")]   
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly ILeaveTypeEntity _Entity;
       

        public LeaveTypeController(ILeaveTypeEntity Entity)
        {
            _Entity = Entity;
           
        }

        // GET: api/LeaveType
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<LeaveType> Get()
        {
            return _Entity.FindAll();
        }

        // GET: api/LeaveType/5
        [HttpGet]
        [Route("GetById{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leaveType = await _Entity.GetByID(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            return Ok(leaveType);
        }

        // POST: api/LeaveType
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Save([FromBody] LeaveType leaveType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _Entity.Create(leaveType);
            return Ok(leaveType);
        }

        // PUT: api/LeaveType/5
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
