using fuel_mgmt_backend.models.fuelStation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fuel_mgmt_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelStationController : ControllerBase
    {
        private readonly IFuelStationService fuelStationService;

        public FuelStationController(IFuelStationService fuelStationService)
        {
            this.fuelStationService = fuelStationService;
        }

        // GET: api/<FuelStationController>
        [HttpGet]
        public ActionResult<List<FuelStation>> Get()
        {
            return fuelStationService.Get();
        }

        // GET: api/<FuelStationController>/email
        [HttpGet("byEmail/{email}")]
        public ActionResult<List<FuelStation>> GetFuelStationsByEmail(string email)
        {
            return fuelStationService.GetFuelStationsByEmail(email);
        }

        // GET api/<FuelStationController>/5
        [HttpGet("{id}")]
        public ActionResult<FuelStation> Get(string id)
        {
            var fuelStation = fuelStationService.Get(id);

            if (fuelStation == null)
            {
                return NotFound($"fuelStation with Id = {id} not found");
            }

            return fuelStation;
        }

        // POST api/<FuelStationController>
        [HttpPost]
        public ActionResult<FuelStation> Post([FromBody] FuelStation fuelStation)
        {
            fuelStationService.Create(fuelStation);

            return CreatedAtAction(nameof(Get), new { id = fuelStation.Id }, fuelStation);
        }

        // PUT api/<FuelStationController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] FuelStation fuelStation)
        {
            var existingFuelStation = fuelStationService.Get(id);

            if (existingFuelStation == null)
            {
                return NotFound($"existingFuelStation with Id = {id} not found");
            }

            fuelStationService.Update(id, fuelStation);

            return NoContent();
        }

        // DELETE api/<FuelStationController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existingFuelStation = fuelStationService.Get(id);

            if (existingFuelStation == null)
            {
                return NotFound($"fuel Station with Id = {id} not found");
            }

            fuelStationService.Delete(id);

            return Ok();
        }

        //query params api/<FuelStationController>/
        [HttpGet("bySearch/{search}")]
        public ActionResult<List<FuelStation>> GetStationsBySearch(String search)
        {
            return fuelStationService.GetStationsBySearch(search);
        }
    }
}