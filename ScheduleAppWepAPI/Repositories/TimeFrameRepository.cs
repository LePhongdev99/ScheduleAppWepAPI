using ScheduleAppWepAPI.Model;

namespace ScheduleAppWepAPI.Repositories
{
    public class TimeFrameRepository : ITimeFrameRepository
    {   
        private readonly AdventureContext _adventureContext;

        public TimeFrameRepository(AdventureContext adventureContext)
        {
            _adventureContext = adventureContext;
        }
        public void CreateTimeFrame()
        {
            for(int x = 0; x <= 9; x++)
            {
                var timeFrame = new TimeFrame();
                timeFrame.Id = x;
                timeFrame.Time = new TimeSpan(x + 7, 0, 0);
                _adventureContext.TimeFrames.Add(timeFrame);
            }           
        }

        public List<TimeFrame> GetAll()
        {
            return _adventureContext.TimeFrames.ToList();
        }

        public void Save()
        {
            _adventureContext.SaveChanges();
        }

        
    }
}
