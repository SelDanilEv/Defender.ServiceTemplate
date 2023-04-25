using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Defender.ServiceTemplate.Domain.Entities;

public interface IBaseModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
}
