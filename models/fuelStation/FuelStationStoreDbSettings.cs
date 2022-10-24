namespace fuel_mgmt_backend.models.fuelStation
{
    public class FuelStationStoreDbSettings : IFuelStationStoreDbSettings
    {
        public string FuelStationCollectionName { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;

    }
}
