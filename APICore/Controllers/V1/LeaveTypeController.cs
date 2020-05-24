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
    [Route("v1/api/[controller]")]
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
        public IEnumerable<LeaveType> Get()
        {
            return _Entity.FindAll();
        }

        // GET: api/LeaveType/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LeaveType
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/LeaveType/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
