using System;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace ProjetoAPI.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Cargo> _cargos;
        public DbClient(IOptions<DBConfig> dbconfig)
        {
            dbconfig.Value.Connection_String = "mongodb://localhost:27017";
            dbconfig.Value.Database_Name = "Projeto";

            var client = new MongoClient(dbconfig.Value.Connection_String);
            var database = client.GetDatabase(dbconfig.Value.Database_Name);
            _cargos = database.GetCollection<Cargo>("Cargos");
        }

        public IMongoCollection<Cargo> GetCargosCollection()
        {
            return _cargos;
        }
    }
}
