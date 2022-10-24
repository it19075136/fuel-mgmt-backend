using MongoDB.Bson.Serialization.Attributes;
namespace fuel_mgmt_backend.models.fuelStation
{
    [BsonIgnoreExtraElements]
    public class FuelStation
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("location")]
        public string Location { get; set; } = String.Empty;
        [BsonElement("stationName")]
        public string StationName { get; set; } = String.Empty;
        [BsonElement("fuelAvailability")]
        public Dictionary<string,Boolean>? FuelAvailability { get; set; }
        [BsonElement("fuelArrivalTime")]
        public DateTime FuelArrivalTime { get; set; }
        [BsonElement("fuelFinishTime")]
        public DateTime FuelFinishTime { get; set; }
        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;
        /* [BsonElement("userRef")]*/
        /*public User? Owner { get; set; }*/
    }
}
