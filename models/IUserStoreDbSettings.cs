using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fuel_mgmt_backend.models
{
    public interface IUserStoreDbSettings
    {
        string UserCollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
