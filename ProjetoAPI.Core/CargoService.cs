using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace ProjetoAPI.Core
{
    public class CargoService : ICargoService
    {
        private readonly IMongoCollection<Cargo> _cargos;

        public CargoService(IDbClient dbClient)
        {
            _cargos = dbClient.GetCargosCollection();
        }

        public Cargo AddCargo(Cargo cargo)
        {
            _cargos.InsertOne(cargo);
            return cargo;
        }

        public List<Cargo> GetCargos()
        {
            return _cargos.Find(x => true).ToList();
        }
    }
}
