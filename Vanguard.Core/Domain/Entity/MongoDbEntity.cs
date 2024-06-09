﻿using Vanguard.Abstraction.Domain;
using MongoDB.Bson;

namespace Vanguard.Core.Domain.Entity
{
    public abstract class MongoDbEntity : IMongoDbEntity
    {
        public MongoDbEntity()
        {
            Id = ObjectId.GenerateNewId();
        }
        public ObjectId Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
