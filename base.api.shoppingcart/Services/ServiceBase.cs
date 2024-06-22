using Shoppingcart.Data.Models;
using MongoDB.Driver;

namespace Shoppingcart.BaseApi.Services;

public abstract class ServiceBase<T> : IServiceBase<T> where T : IModelBase, new()
{
    private readonly IMongoCollection<T> _collection;

    private readonly FilterDefinitionBuilder<T> filterBuilder = Builders<T>.Filter;

    protected ServiceBase(IMongoCollection<T> collection)
    {
        _collection = collection;
    }

    public virtual async Task<bool> DeleteRecordAsync(string Id)
    {
        var filter = filterBuilder.Eq(item => item.Id, Id);
        var result = await _collection.DeleteOneAsync(filter);

        return (result.DeletedCount > 0);
    }

    public virtual async Task<IEnumerable<T>> GetAllRecordsAsync()
    {
        var records = await _collection.Find(_ => true).ToListAsync();
        return records;
    }

    public virtual async Task<T> GetSingleRecordAsync(string Id)
    {
        var filter = filterBuilder.Eq(item => item.Id, Id);
        var records = await _collection.Find(filter).ToListAsync();

        return (records.Count > 0) ? records[0] : new T();
    }

    public virtual async Task<T> NewRecordAsync(T record)
    {
        await _collection.InsertOneAsync(record);
        return record;
    }

    public virtual async Task<bool> UpdateRecordAsync(T record)
    {
        var filter = filterBuilder.Eq(item => item.Id, record.Id);
        var result = await _collection.ReplaceOneAsync(filter, record, new ReplaceOptions { IsUpsert = false });

        return (result.ModifiedCount > 0);
    }
}