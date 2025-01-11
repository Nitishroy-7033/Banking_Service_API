using bankservice.Models.Exceptions;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;

namespace bankservice.DbContexts
{
    public class MongoDbContext<T>
    {
        private readonly Dictionary<string, string> Collections = new()
            {
          
            };

        private IMongoDatabase Database { get; }
        public IMongoCollection<T> Collection { get; }

        public MongoDbContext(MongoDbConfigs mongoDbConfigs)
        {
            MongoClientSettings clientSettings = MongoClientSettings.FromConnectionString(mongoDbConfigs.ConnectionString);

            if (mongoDbConfigs.EnableCommandTracing)
            {
                var logger = Serilog.Log.Logger;
                clientSettings.ClusterConfigurator = builder =>
                {
                    builder.Subscribe<CommandStartedEvent>(_ =>
                    {
                        logger.Debug($"Mongo Command started: {_.Command}");
                    });
                };
            }

            var client = new MongoClient(clientSettings);
            Database = client.GetDatabase(mongoDbConfigs.DatabaseName);

            Collection = Database.GetCollection<T>(GetCollectionName());
        }

        public string GetCollectionName()
        {
            string collName = string.Empty;
            try
            {
                Type type = typeof(T);
                collName = Collections[type.Name];
            }
            catch
            {
                // Not required action
            }
            if (string.IsNullOrWhiteSpace(collName))
            {
                throw new CustomException("Collection name is empty.", "");
            }
            return collName;
        }
    }
}
