using Microsoft.AspNetCore.Mvc;

namespace Shoppingcart.BaseApi.Authentication;

public class ApiKeyAttribute : ServiceFilterAttribute
{
    /// <summary>
    /// 
    /// </summary>
    public ApiKeyAttribute() : base(typeof(ApiKeyAuthorizationFilter)) { }
}