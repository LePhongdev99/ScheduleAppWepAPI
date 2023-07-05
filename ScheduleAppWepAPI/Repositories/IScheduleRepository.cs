using ScheduleAppWepAPI.Model;
namespace ScheduleAppWepAPI.Repositories

{
    public interface IScheduleRepository
    {
        public void CreateSchedule(int id);
        public List<Schedule> GetSchedules();
        public void Save();
    }
}
