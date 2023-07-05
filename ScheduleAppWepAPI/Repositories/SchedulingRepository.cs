using ScheduleAppWepAPI.Model;

namespace ScheduleAppWepAPI.Repositories
{
    public class SchedulingRepository : ISchedulingRepository
    {
        private AdventureContext _context;
        public SchedulingRepository(AdventureContext context)
        {
            _context = context;
        }

        public void CreateScheduling(int id, int scheduleId, int subjectId)
        {
            var scheduling = new Scheduling();
            scheduling.Id = id;
            scheduling.ScheduleId = scheduleId;
            scheduling.SubjectId = subjectId;
            _context.Schedulings.Add(scheduling);
        }

        public List<Scheduling> GetSchedulings()
        {
            return _context.Schedulings.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
