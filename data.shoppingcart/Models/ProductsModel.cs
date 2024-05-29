namespace Shoppingcart.Data.Models;

/// <summary>
/// 
/// </summary>
public record ProductsModel : ModelBase
{
    public string Description { get; set; } = string.Empty;

    public decimal Value { get; set; } = 0.0M;

    public int InStock { get; set; } = 0;
}