using data.shoppingcart.Models;

namespace data.shoppingcart.DTOs;

/// <summary>
/// 
/// </summary>
public abstract record BaseDTO : IModelBase
{
    public string? Id { get; init; }

    public DateTimeOffset CreatedDate { get; init; } = DateTimeOffset.UtcNow;

    public bool Active { get; init; } = true;
}