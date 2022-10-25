namespace fuel_mgmt_backend.models
{
    public interface IScheduleStoreDbSettings
    {
        string ScheduleCollectionName { get; set; }

        string DatabaseName { get; set; }

        string ConnectionString { get; set; }

    }
}
