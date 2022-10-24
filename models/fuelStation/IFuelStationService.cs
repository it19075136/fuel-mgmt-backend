namespace fuel_mgmt_backend.models.fuelStation
{
    public interface IFuelStationService
    {
        List<FuelStation> Get();
        FuelStation Get(string id);
        /*List<FuelStation> GetFuelStationsByEmail(string email);*/
        FuelStation Create(FuelStation fuelStation);
        void Update(string id, FuelStation fuelStation);
        void Delete(string id);

    }
}
