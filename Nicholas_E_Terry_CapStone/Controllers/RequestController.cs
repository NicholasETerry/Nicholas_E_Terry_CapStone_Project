using Microsoft.AspNetCore.Mvc;
using Nicholas_E_Terry_CapStone.Data;
using Nicholas_E_Terry_CapStone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nicholas_E_Terry_CapStone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RequestController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<RequestController>
        [HttpGet]
        public IActionResult Get()
        {

            return Ok();
        }
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok();
        //}

        // GET api/<RequestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RequestController>
        [HttpPost]
        public IActionResult Post([FromBody] ContributorComment newComment)
        {
            // comment
            // article id
            //user id
            //newComment.Contributor_Comment_UserModel_Id = Convert.ToInt32(listReturned[2]);
            _context.ContributorComments.Add(newComment);
            _context.SaveChanges();

            return Ok(newComment);
        }

        // PUT api/<RequestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
