using caseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace caseStudy.Controllers
{

    [ApiController]
    public class EquitiesController : ControllerBase
    {
        public GIContext _dbcontext;
        public EquitiesController()
        {
             _dbcontext = new GIContext();
        }

        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult GetEquities()
        {
            return Ok(_dbcontext.Equities.ToList());
        }

        [Route("api/[controller]/{id}")]
        [HttpGet]
        public IActionResult GetOneEquity(int id)
        {
            var a = _dbcontext.Equities.Where(e => e.SecurityId == id).SingleOrDefault();
            if (a == null)
                return BadRequest();

            return Ok(a);
        }



        [Route("api/[controller]")]
        [HttpPost]
        public IActionResult postequity([FromBody] Equity e)
        {
            if(e.SecurityId==0)
                return BadRequest("Enter SecurityId");
               if (_dbcontext.Equities.Where(eq =>eq.SecurityId == e.SecurityId).SingleOrDefault() != null)
                return BadRequest("Already Exist");
            _dbcontext.Equities.Add(e);
            _dbcontext.SaveChanges();
            return Ok(e);
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public IActionResult DeleteEquity(int id)
        {
            var equ = _dbcontext.Equities.Where(e => e.SecurityId == id).SingleOrDefault();
            if (equ == null)
                return BadRequest();

            _dbcontext.Equities.Remove(equ);
            _dbcontext.SaveChanges();
            return Ok(equ);

        }

        [Route("api/[controller]/{id}")]
        [HttpPut]
        public IActionResult PutEquity(int id, [FromBody] Equity e)
        {
            var eq=_dbcontext.Equities.Where(e => e.SecurityId == id).SingleOrDefault();
            if (eq == null)
                return BadRequest();


            _dbcontext.Equities.Remove(eq);
            string sd = JsonSerializer.Serialize<Equity>(eq);
            string si = JsonSerializer.Serialize(e);
            JObject jsonsd=JObject.Parse(sd);
            JObject jsonsi=JObject.Parse(si);


            foreach(var j in jsonsi )
            {
                if (j.Value.ToString().Trim() == "" || j.Value == null||j.Value.ToString()=="0")
                    continue;
                jsonsd[j.Key] = j.Value;
            }
            sd = jsonsd.ToString();
            eq = JsonSerializer.Deserialize<Equity>(sd);
            _dbcontext.Equities.Add(eq);
            _dbcontext.SaveChanges();
            return Ok(eq);
        }
    }

}
