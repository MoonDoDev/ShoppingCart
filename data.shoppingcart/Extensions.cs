using data.shoppingcart.DTOs;
using data.shoppingcart.Models;

namespace data.shoppingcart;

/// <summary>
/// 
/// </summary>
public static class Extensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="usersModel"></param>
    /// <returns></returns>
    public static UsersDTO AsUsersDTO(this UsersModel usersModel)
    {
        return new UsersDTO
        {
            Id = usersModel.Id,
            CreatedDate = usersModel.CreatedDate,
            Active = usersModel.Active,
            LoginName = usersModel.LoginName,
            Password = usersModel.Password,
            FirstName = usersModel.FirstName,
            LastName = usersModel.LastName,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productsModel"></param>
    /// <returns></returns>
    public static ProductsDTO AsProductsDTO(this ProductsModel productsModel)
    {
        return new ProductsDTO
        {
            Id = productsModel.Id,
            CreatedDate = productsModel.CreatedDate,
            Active = productsModel.Active,
            Description = productsModel.Description,
            Value = productsModel.Value,
            InStock = productsModel.InStock,
        };
    }
}