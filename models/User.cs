using MongoDB.Bson.Serialization.Attributes;

namespace fuel_mgmt_backend.models
{
    [BsonIgnoreExtraElements]
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set;  } =  String.Empty;
        [BsonElement("name")]
        public string Email { get; set;  } = String.Empty;
        [BsonElement("password")]
        public string Password { get; set;  } = String.Empty;
    }
}
