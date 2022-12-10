using MongoDB.Bson.Serialization.Attributes;

namespace Rentel.ServiceTemplate.Domain.Entities.Sample;

public class SampleModel : IBaseModel
{
    [BsonId]
    public Guid Id { get; set; }
}
