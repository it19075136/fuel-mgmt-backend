namespace fuel_mgmt_backend.models.fuelStation
{
    public interface IFuelStationService
    {
        List<FuelStation> Get();
        FuelStation Get(string id);
        List<FuelStation> GetFuelStationsByEmail(string email);
        List<FuelStation> GetStationsBySearch(string search);
        FuelStation Create(FuelStation fuelStation);
        FuelStation Update(string id, FuelStation fuelStation);
        void Delete(string id);

    }
}
