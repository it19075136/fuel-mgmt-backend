using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace fuel_mgmt_backend.models
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IUserStoreDbSettings userStoreDbSettings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(userStoreDbSettings.DatabaseName);
            _users = database.GetCollection<User>(userStoreDbSettings.UserCollectionName);
        }

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public List<User> Get()
        {
            return _users.Find(user => true).ToList();
        }

        public void Delete(string id)
        {
            _users.DeleteOne(user => user.Id == id);
        }

        public User Get(string id)
        {
            return _users.Find(user => user.Id == id).FirstOrDefault();
        }

        public void Update(string id, User user)
        {
            _users.ReplaceOne(user => user.Id == id, user);
        }
        public User GetByEmail(string email)
        {
            return _users.Find(user => user.Email == email).FirstOrDefault();
        }
    }
}
