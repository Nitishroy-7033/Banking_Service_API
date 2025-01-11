namespace bankservice.DbContexts
{
    public class MongoDbConfigs
    {
        public const string Option = "MongoDbConfigs";
        public required string ConnectionString { get; set; }
        public required string DatabaseName { get; set; }
        public bool EnableCommandTracing { get; set; }
    }
}
