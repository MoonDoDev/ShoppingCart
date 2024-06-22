public record AppSettings
{
    public string DBServerName { get; set; } = "localhost";
    public string DBUserName { get; set; } = string.Empty;
    public string DBUserPass { get; set; } = string.Empty;

    public string ConnectionString
    {
        get
        {
            return $"mongodb://{DBUserName}:{DBUserPass}@{DBServerName}:27017";
        }
    }
}