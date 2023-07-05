using Microsoft.AspNetCore.Mvc;
using ScheduleAppWepAPI.Model;
using ScheduleAppWepAPI.Repositories;

namespace ScheduleAppWepAPI.Controllers
{
    [Controller]
    public class SchedulingController : Controller
    {
        private readonly AdventureContext _context;
        private readonly ISchedulingRepository _schedulingRepository;
        public SchedulingController(AdventureContext adventureContext, ISchedulingRepository schedulingRepository)
        {
            _context = adventureContext;
            _schedulingRepository = schedulingRepository;
        }

        [HttpPost]
        [Route("CreateScheduling")]

        public void CreateScheduling(int id, int scheduleId, int subjectId)
        {
            _schedulingRepository.CreateScheduling(id, scheduleId, subjectId);
            _schedulingRepository.Save();
        }

        [HttpGet]
        [Route("GetSchedulings")]

        public List<Scheduling> GetSchedulings() 
        {
            return _schedulingRepository.GetSchedulings();
        }
    }
}
