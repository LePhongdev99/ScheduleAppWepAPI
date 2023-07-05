using Microsoft.AspNetCore.Mvc;
using ScheduleAppWepAPI.Model;
using ScheduleAppWepAPI.Repositories;

namespace ScheduleAppWepAPI.Controllers
{
    [ApiController]
    public class ScheduleController : Controller
    {
        private readonly AdventureContext _context;
        private readonly IScheduleRepository _scheduleRepository;   
        public ScheduleController(AdventureContext context, IScheduleRepository scheduleRepository)
        {
            _context = context;
            _scheduleRepository = scheduleRepository;
        }

        [HttpPost]
        [Route("CreateSchedule")]
        public void CreateSchedule(int id)
        {
            _scheduleRepository.CreateSchedule(id);
            _scheduleRepository.Save();
        }

        [HttpGet]
        [Route("GetSchedules")]
        public List<Schedule> GetSchedules()
        {
            return _scheduleRepository.GetSchedules();
        }
    }
}
