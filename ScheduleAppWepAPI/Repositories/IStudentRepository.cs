using ScheduleAppWepAPI.Model;

namespace ScheduleAppWepAPI.Repositories
{
    public interface IStudentRepository
    {
        public void CreateStudent(int id, string name, string email, string address, int scheduleId);
        public object GetSchedule(int id);
        public void Save();
        
    }
}
