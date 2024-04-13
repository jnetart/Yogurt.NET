namespace Yogurt.NET;

partial class Yogurt
{
    public sealed class Redis
    {
        public string ConnectionString { get; set; } = string.Empty;
        public Sentinel? SentinelOptions { get; set; }
    
        public sealed class Sentinel
        {
            
        }
    }
}