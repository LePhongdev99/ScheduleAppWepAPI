using ScheduleAppWepAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ScheduleAppWepAPI.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly AdventureContext _adventureContext;

        public SubjectRepository(AdventureContext adventureContext)
        {
            _adventureContext = adventureContext;
        }
        public void CreateSubject(int id, string name,string dayOfWeek, int timeBeginId, int timeEndId)
        {
            var subject = new Subject();
            subject.Id = id;
            subject.Name = name;
            subject.TimeBeginId = timeBeginId;
            subject.TimeEndId = timeEndId;
            subject.DayOfWeek = dayOfWeek;
            _adventureContext.Subjects.Add(subject);
        }

        public void DeletedSubjectByName(string name)
        {
            var subject = _adventureContext.Subjects.FirstOrDefault(x => x.Name == name);
            if (subject != null)
            {
                _adventureContext.Subjects.Remove(subject);
            }
        }

        public List<Subject> GetSubjectByName(string name)
        {
            List<Subject> subjects = _adventureContext.Subjects.Include(p=>p.TimeBegin).Include(p=>p.TimeEnd).Where(p => p.Name == name).ToList(); 
            return subjects;
        }

        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = _adventureContext.Subjects.ToList();
            return subjects;
        }

        public void Save()
        {
            _adventureContext.SaveChanges();
        }
    }
}
