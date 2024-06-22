using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Shoppingcart.BaseApi.Authentication;

public class ApiKeyAuthorizationFilter : IAuthorizationFilter
{
    private const string ApiKeyHeaderName = "x-api-key";

    private readonly IApiKeyValidator _apiKeyValidator;

    public ApiKeyAuthorizationFilter(IApiKeyValidator apiKeyValidator)
    {
        _apiKeyValidator = apiKeyValidator;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        string? apiKey = context.HttpContext.Request.Headers[ApiKeyHeaderName];
        string endPoint = context.HttpContext.Request.Path.Value ?? string.Empty;

        var result = _apiKeyValidator.IsValidRequest(endPoint, apiKey);

        if (!result.Result)
            context.Result = new UnauthorizedResult();
    }
}