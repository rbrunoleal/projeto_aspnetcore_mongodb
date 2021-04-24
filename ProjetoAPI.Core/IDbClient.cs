using System;
using MongoDB.Driver;

namespace ProjetoAPI.Core
{
    public interface IDbClient
    {
        IMongoCollection<Cargo> GetCargosCollection();
    }
}
