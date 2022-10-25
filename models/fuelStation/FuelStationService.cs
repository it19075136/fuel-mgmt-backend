using MongoDB.Driver;
namespace fuel_mgmt_backend.models.fuelStation
{
    public class FuelStationService : IFuelStationService
    {
        private readonly IMongoCollection<FuelStation> _fuelStation;

        public FuelStationService(IFuelStationStoreDbSettings fuelStationStoreDbSettings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(fuelStationStoreDbSettings.DatabaseName);
            _fuelStation = database.GetCollection<FuelStation>(fuelStationStoreDbSettings.FuelStationCollectionName);
        }

        public FuelStation Create(FuelStation fuelStation)
        {
            _fuelStation.InsertOne(fuelStation);
            return fuelStation;
        }

        public List<FuelStation> Get()
        {
            return _fuelStation.Find(fuelStation => true).ToList();
        }

        public List<FuelStation> GetFuelStationsByEmail(string email)
        {

            return _fuelStation.Find(fuelStation => fuelStation.Email == email).ToList();

        }

        public void Delete(string id)
        {
            _fuelStation.DeleteOne(fuelStation => fuelStation.Id == id);
        }

        public FuelStation Get(string id)
        {
            return _fuelStation.Find(fuelStation => fuelStation.Id == id).FirstOrDefault();
        }

        public void Update(string id, FuelStation fuelStation)
        {
            _fuelStation.ReplaceOne(fuelStation => fuelStation.Id == id, fuelStation);
        }

    }
}
