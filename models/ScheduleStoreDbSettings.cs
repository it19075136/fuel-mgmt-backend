namespace fuel_mgmt_backend.models
{
    public class ScheduleStoreDbSettings : IScheduleStoreDbSettings
    {
        public string ScheduleCollectionName { get; set; } = String.Empty;

        public string DatabaseName { get; set; } = String.Empty;

        public string ConnectionString { get; set; } = String.Empty;
    }
}
