using System.ComponentModel.DataAnnotations;

namespace Shoppingcart.Data.DTOs;

/// <summary>
/// 
/// </summary>
public record NewUpdUsersDTO
{
    [Required(ErrorMessage = ErrorMessages.FIELD_IS_REQUIRED)]
    public string LoginName { get; set; } = string.Empty;

    [Required(ErrorMessage = ErrorMessages.FIELD_IS_REQUIRED)]
    [MaxLength(32, ErrorMessage = ErrorMessages.FIELDS_MAX_SIZE)]
    [MinLength(8, ErrorMessage = ErrorMessages.PASSWORD_FIELD_MIN_SIZE)]
    public string Password { get; set; } = string.Empty;

    [MaxLength(32, ErrorMessage = ErrorMessages.FIELDS_MAX_SIZE)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(32, ErrorMessage = ErrorMessages.FIELDS_MAX_SIZE)]
    public string LastName { get; set; } = string.Empty;
}