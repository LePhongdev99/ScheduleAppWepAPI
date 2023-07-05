using Microsoft.AspNetCore.Mvc;
using ScheduleAppWepAPI.Model;
using ScheduleAppWepAPI.Repositories;

namespace ScheduleAppWepAPI.Controllers
{
    [Controller]
    [Route("/")]
    public class SubjectController : Controller
    {   
        private readonly AdventureContext _context;
        private readonly ISubjectRepository subjectRepository;

        public SubjectController(AdventureContext context, ISubjectRepository subjectRepository)
        {
            _context = context;
            this.subjectRepository = subjectRepository;
        }
        

        [HttpPost]
        [Route("CreateSubject")]
        public void CreateSubject(int id, string name,string dayOfWeek, int timeBeginId, int timeEndId)
        {
            subjectRepository.CreateSubject(id, name,dayOfWeek, timeBeginId , timeEndId);
            subjectRepository.Save();
        }

        [HttpGet]
        [Route("GetSubjectByName")]

        public List<Subject> GetSubjects(string name) 
        {
            return subjectRepository.GetSubjectByName(name);
        }

        [HttpGet]
        [Route("DeletedSubjectByName")]
        public void DeletedSubjectByName(string name)
        {
            subjectRepository.DeletedSubjectByName(name);
            subjectRepository.Save();
        }

        [HttpGet]
        [Route("GetAllSubjects")]
        public List<Subject> GetSubjects()
        {
            return subjectRepository.GetSubjects();
        }
    }
}
