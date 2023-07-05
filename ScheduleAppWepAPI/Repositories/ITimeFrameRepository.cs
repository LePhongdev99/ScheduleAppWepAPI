using ScheduleAppWepAPI.Model;
namespace ScheduleAppWepAPI.Repositories
{
    public interface ITimeFrameRepository
    {
        public void CreateTimeFrame();
        public List<TimeFrame> GetAll();
        public void Save();
    }
}
