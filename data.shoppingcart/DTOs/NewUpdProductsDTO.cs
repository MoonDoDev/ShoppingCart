using System.ComponentModel.DataAnnotations;

namespace Shoppingcart.Data.DTOs;

/// <summary>
/// 
/// </summary>
public record NewUpdProductsDTO
{
    [Required(ErrorMessage = ErrorMessages.FIELD_IS_REQUIRED)]
    [MaxLength(60, ErrorMessage = ErrorMessages.DESCRIPTION_FIELD_MAX_SIZE)]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = ErrorMessages.FIELD_IS_REQUIRED)]
    public decimal Value { get; set; } = 0.0M;

    [Required(ErrorMessage = ErrorMessages.FIELD_IS_REQUIRED)]
    public int InStock { get; set; } = 0;
}