using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fuel_mgmt_backend.models
{
    public class UserStoreDbSettings : IUserStoreDbSettings
    {
        public string UserCollectionName { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string ScheduleCollectionName { get; set; } = String.Empty;
    }
}