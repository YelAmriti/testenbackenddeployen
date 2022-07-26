using DataLaag;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoVideoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreinController : ControllerBase
    {
        private DatabaseContext _mdc;

        public TreinController(DatabaseContext mdc)
        {
            _mdc = mdc;
        }



        // GET: api/<TreinController>
        [HttpGet]
        public IEnumerable<Trein> Get()
        {
            Trein trein = new Trein();
            trein.Conducteur = "Johan";
            trein.ThuisStation = "Eindhoven";
            trein.Snelheid = 25;
            _mdc.Add(trein);
            _mdc.SaveChanges();
            
            return _mdc.treinen;
        }

        // GET api/<TreinController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TreinController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TreinController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TreinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
