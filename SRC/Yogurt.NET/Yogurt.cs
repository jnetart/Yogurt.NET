namespace Yogurt.NET;

public sealed partial class Yogurt
{
    public Redis? RedisOptions { get; set; }
    public MongoDB? MongoDbOptions { get; set; }
}