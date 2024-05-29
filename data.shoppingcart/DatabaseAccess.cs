using MongoDB.Driver;

namespace Shoppingcart.Data;

public class DatabaseAccess
{
    private const string _databaseName = "shoppingcartdb";

    private readonly IMongoDatabase _database;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mongoClient"></param>
    public DatabaseAccess(IMongoClient mongoClient)
    {
        _database = mongoClient.GetDatabase(_databaseName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collectionName"></param>
    /// <returns></returns>
    public IMongoCollection<T> GetMongoDBCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}
