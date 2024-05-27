namespace data.shoppingcart.DTOs;

/// <summary>
/// 
/// </summary>
public record ProductsDTO : BaseDTO
{
    public string Description { get; set; } = string.Empty;

    public decimal Value { get; set; } = 0.0M;

    public int InStock { get; set; } = 0;
}