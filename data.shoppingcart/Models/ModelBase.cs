using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shoppingcart.Data.Models;

/// <summary>
/// 
/// </summary>
public abstract record ModelBase : IModelBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; init; }

    public DateTimeOffset CreatedDate { get; init; } = DateTimeOffset.UtcNow;

    public bool Active { get; init; } = true;

    public override string ToString() => $"Record <{Id}>, Created <{CreatedDate}>";
}