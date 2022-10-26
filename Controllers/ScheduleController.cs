using fuel_mgmt_backend.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fuel_mgmt_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }

        // GET: api/<ScheduleController>
        [HttpGet]
        public ActionResult<List<Schedule>> Get()
        {
            return scheduleService.Get();
        }

        // GET api/<ScheduleController>/5
        [HttpGet("{id}")]
        public ActionResult<Schedule> Get(string id)
        {
            var schedule = scheduleService.Get(id);

            if (schedule == null)
            {
                return NotFound($"Schedule with Id = {id} not found");
            }

            return schedule;
        }

        // POST api/<ScheduleController>
        [HttpPost]
        public ActionResult<Schedule> Post([FromBody] Schedule schedule)
        {
            scheduleService.Create(schedule);

            return CreatedAtAction(nameof(Get), new { id = schedule.Id }, schedule);
        }

        // PUT api/<ScheduleController>/5
        [HttpPut("{id}")]
        public ActionResult<Schedule> Put(string id, [FromBody] Schedule schedule)
        {
            var existingSchedule = scheduleService.Get(id);

            if(existingSchedule == null)
            {
                return NotFound($"Schedule with Id = {id} not found");

            }

            return scheduleService.Update(id, schedule);

        }

        // DELETE api/<ScheduleController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existingSchedule = scheduleService.Get(id);

            if(existingSchedule == null)
            {
                return NotFound($"Schedule with Id = {id} not found");
            }

            scheduleService.delete(id);

            return Ok();
        }
    }
}
