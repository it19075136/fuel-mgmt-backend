namespace fuel_mgmt_backend.models.fuelStation
{
    public interface IFuelStationStoreDbSettings
    {
        string FuelStationCollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
