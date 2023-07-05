using Microsoft.AspNetCore.Mvc;
using ScheduleAppWepAPI.Model;
using ScheduleAppWepAPI.Repositories;

namespace ScheduleAppWepAPI.Controllers
{
    [Controller]
    public class StudentController : Controller
    {
        private AdventureContext _context;
        private IStudentRepository _studentRepository;
        public StudentController(AdventureContext context, IStudentRepository studentRepository)
        {
            _context = context;
            _studentRepository = studentRepository;
        }
        [HttpPost]
        [Route("CreateStudent")]
        public void CreateStudent(int id, string name, string email, string address, int scheduleId)
        {
            _studentRepository.CreateStudent(id,name, email, address, scheduleId);
            _studentRepository.Save();
        }

        [HttpGet]
        [Route("GetSchedule")]
        public object GetSchedule(int id)
        {
            return _studentRepository.GetSchedule(id);
        }
    }
}
