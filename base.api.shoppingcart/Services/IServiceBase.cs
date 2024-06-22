namespace Shoppingcart.BaseApi.Services;

public interface IServiceBase<T>
{
    Task<IEnumerable<T>> GetAllRecordsAsync();

    Task<T> GetSingleRecordAsync(string Id);

    Task<T> NewRecordAsync(T record);

    Task<bool> UpdateRecordAsync(T record);

    Task<bool> DeleteRecordAsync(string Id);

}