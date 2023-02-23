using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using caseStudy.Models;


namespace caseStudy.Controllers
{
    [ApiController]
    public class BondController : ControllerBase
    {
        public GIContext _dbcontext;
        public BondController()
        {
            _dbcontext = new GIContext();
        }

        [Route("api/Bond")]
        [HttpGet]
        public IActionResult GetBonds()
        {
            return Ok(_dbcontext.Bonds.ToList());
        }

        [Route("api/Bond/{id}")]
        [HttpGet]
        public IActionResult GetOneBond(int id)
        {
            var a = _dbcontext.Bonds.Where(e => e.BondId == id).SingleOrDefault();
            if (a == null)
                return BadRequest();

            return Ok(a);
        }

        [Route("api/Bond/{id}")]
        [HttpDelete]
        public IActionResult DeleteBond(int id)
        {
            var equ = _dbcontext.Bonds.Where(e => e.BondId == id).SingleOrDefault();
            if (equ == null)
                return BadRequest();

            _dbcontext.Bonds.Remove(equ);
            _dbcontext.SaveChanges();
            return Ok(equ);

        }


        [Route("api/[controller]")]
        [HttpPost]
        public IActionResult Getinserted([FromBody] Bond e)
        {
            if (e.BondId == 0)
                return BadRequest("Enter Correct BondId");
            if (_dbcontext.Bonds.Where(b => b.BondId == e.BondId).SingleOrDefault() != null)
                return BadRequest("Already Exist");

                _dbcontext.Bonds.Add(e);
                _dbcontext.SaveChanges();
            return Ok(e);
        }

        [HttpPut("api/[controller]/{id}")]
        public IActionResult PutBond(int id, [FromBody] Bond e)
        {
            var eq = _dbcontext.Bonds.Where(e => e.BondId == id).SingleOrDefault();
            if (eq == null)
                return BadRequest();


            _dbcontext.Bonds.Remove(eq);
            string sd = JsonSerializer.Serialize<Bond>(eq);
            string si = JsonSerializer.Serialize(e);
            JObject jsonsd = JObject.Parse(sd);
            JObject jsonsi = JObject.Parse(si);


            foreach (var j in jsonsi)
            {
                if (j.Value.ToString().Trim() == "" || j.Value == null || j.Value.ToString() == "0")
                    continue;
                jsonsd[j.Key] = j.Value;
            }
            sd = jsonsd.ToString();
            eq = JsonSerializer.Deserialize<Bond>(sd);
            _dbcontext.Bonds.Add(eq);
            _dbcontext.SaveChanges();
            return Ok(eq);


        }
    }
}


