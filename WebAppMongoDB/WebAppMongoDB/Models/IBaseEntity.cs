using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebAppMongoDB.Models
{
    public interface IBaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string? Id { get; set; }
    }
}
