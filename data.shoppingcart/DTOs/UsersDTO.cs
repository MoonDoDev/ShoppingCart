namespace Shoppingcart.Data.DTOs;

/// <summary>
/// 
/// </summary>
public record UsersDTO : BaseDTO
{
    public string LoginName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}