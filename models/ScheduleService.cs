
using MongoDB.Driver;

namespace fuel_mgmt_backend.models
{
    public class ScheduleService : IScheduleService
    {
        private readonly IMongoCollection<Schedule> _schedules;

        public ScheduleService(IUserStoreDbSettings scheduleStoreDbSettings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(scheduleStoreDbSettings.DatabaseName);
            _schedules = database.GetCollection<Schedule>(scheduleStoreDbSettings.ScheduleCollectionName);
        }

        public Schedule Create(Schedule schedule)
        {
            //schedule.IsPumped = false;
            _schedules.InsertOne(schedule);
            return schedule;
        }

        public void delete(string id)
        {
            _schedules.DeleteOne(schedule => schedule.Id == id);
        }

        public List<Schedule> Get()
        {
            return _schedules.Find(schedule => true).ToList();
        }

        public Schedule Get(string id)
        {
            return _schedules.Find(schedule => schedule.Id == id).FirstOrDefault();
        }

        public Schedule Update(string id, Schedule schedule)
        {
            _schedules.ReplaceOne(schedule => schedule.Id == id, schedule);
            return schedule;
        }
    }
}
