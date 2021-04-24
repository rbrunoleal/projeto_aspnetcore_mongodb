using System;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjetoAPI.Core
{
    public class Cargo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]   
        public string Id { get; set; }
        public string Descricao { get; set; }

    }
}
