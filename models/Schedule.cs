using MongoDB.Bson.Serialization.Attributes;

namespace fuel_mgmt_backend.models
{
    public class Schedule
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;
        [BsonElement("vehicleType")]
        public string VehicleType { get; set; } = String.Empty;
        [BsonElement("arrival")]
        public string Arrival { get; set; } = String.Empty;
        [BsonElement("date")]
        public string StationId { get; set; } = String.Empty;
        [BsonElement("stationId")]
        public string Departure { get; set; } = String.Empty;
        [BsonElement("isPumped")]
        public Boolean IsPumped { get; set; } = false;

    }
}
