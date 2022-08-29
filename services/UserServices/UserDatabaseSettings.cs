using BlogWithMongo_BackEnd.Database;

namespace BlogWithMongo_BackEnd.UserServices
{
    public class UserDatabaseSettings : IDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}