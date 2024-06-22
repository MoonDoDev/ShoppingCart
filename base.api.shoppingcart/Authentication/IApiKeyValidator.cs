namespace Shoppingcart.BaseApi.Authentication;

public interface IApiKeyValidator
{
    Task<bool> IsValidRequest(string endPoint, string? apiKey);
}

