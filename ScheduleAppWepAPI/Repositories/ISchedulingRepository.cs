using ScheduleAppWepAPI.Model;

namespace ScheduleAppWepAPI.Repositories
{
    public interface ISchedulingRepository
    {
        public void CreateScheduling(int id, int scheduleId, int subjectId);
        public void Save();
        public List<Scheduling> GetSchedulings();
    }
}
