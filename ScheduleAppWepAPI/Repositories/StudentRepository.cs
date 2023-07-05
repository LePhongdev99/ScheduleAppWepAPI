using ScheduleAppWepAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ScheduleAppWepAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AdventureContext _context;
        public StudentRepository(AdventureContext context)
        {
            _context = context;
        }
        public void CreateStudent(int id, string name, string email, string address, int scheduleId)
        {
            var student = new Student { Id = id, Name = name, Email = email, Address = address, ScheduleId = scheduleId};
            _context.Students.Add(student);
        }

        public object GetSchedule(int id)
        {
            var student = _context.Students.Include(p => p.Schedule.Schedulings).ThenInclude(p => p.Subject).Where(p => p.Id == id).Select(s=> new
            {
                studentName = s.Name,
                schedule = s.Schedule.Schedulings
            }).FirstOrDefault();
            /*var Schedulestd = _context.Students.Where(p => p.Id == id).Select(s => new
            {
                studentName = s.Name,
                schedule = s.Schedule.Schedulings

            }).FirstOrDefault();*/
            return student;    
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
