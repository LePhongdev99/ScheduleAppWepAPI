using ScheduleAppWepAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ScheduleAppWepAPI.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private AdventureContext _context;
        public ScheduleRepository(AdventureContext context)
        {
            _context = context;
        }
        public void CreateSchedule(int id)
        {
            var schedule = new Schedule();
            schedule.Id = id;
            _context.Schedules.Add(schedule);
        }

        public List<Schedule> GetSchedules()
        {
            return _context.Schedules.Include(p=>p.Schedulings).ThenInclude(p=>p.Subject).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
