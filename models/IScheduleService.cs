namespace fuel_mgmt_backend.models
{
    public interface IScheduleService
    {
        List<Schedule> Get();

        Schedule Get(string id);

        Schedule Create(Schedule schedule);

        Schedule Update(String id, Schedule schedule);

        void delete(String id);
    }
}
