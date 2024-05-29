namespace Shoppingcart.Data.Models;

/// <summary>
/// 
/// </summary>
public record UsersModel : ModelBase
{
    public string LoginName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}