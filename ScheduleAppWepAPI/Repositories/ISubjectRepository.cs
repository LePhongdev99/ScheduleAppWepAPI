using ScheduleAppWepAPI.Model;
namespace ScheduleAppWepAPI.Repositories
{
    public interface ISubjectRepository 
    {
        public void CreateSubject(int id, string name, string dayOfWeek, int timeBeginId, int timeEndId);
        public List<Subject> GetSubjectByName(string name);
        public void DeletedSubjectByName(string name);
        public void Save();
        public List<Subject> GetSubjects();       
    }
}
