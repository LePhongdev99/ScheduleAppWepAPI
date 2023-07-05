using Microsoft.AspNetCore.Mvc;
using ScheduleAppWepAPI.Repositories;
using ScheduleAppWepAPI.Model;


namespace ScheduleAppWepAPI.Controllers
{
    [ApiController]
    
    public class TimeFrameController : ControllerBase
    {   
        private AdventureContext _context;
        private ITimeFrameRepository _timeFrameRepository;
        public TimeFrameController(ITimeFrameRepository timeFrameRepository, AdventureContext adventureContext)
        {
            _timeFrameRepository = timeFrameRepository;
            _context = adventureContext;
        }
        [HttpPost]
        [Route("CreateTimeFrame")]
        public void CreateTimeFrame()
        {
            _timeFrameRepository.CreateTimeFrame();
            _timeFrameRepository.Save();
        }

        [HttpGet]
        [Route("GetAllTimeFrame")]

        public List<TimeFrame> GetTimeFrames()
        {
            return _timeFrameRepository.GetAll();

        }
    }
}
