namespace data.shoppingcart.Models;

/// <summary>
/// 
/// </summary>
public interface IModelBase
{
    string? Id { get; init; }

    DateTimeOffset CreatedDate { get; init; }

    bool Active { get; init; }

    string ToString();
}