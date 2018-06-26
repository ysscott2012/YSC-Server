using YSC_Server.Models;

namespace YSC_Server.Extension
{
    public static class DatabaseConfigurationExtensions
    {
        public static string GetMySqlConnectionString(this DatabaseConfiguration dbConfig)
        {
            return string.Format("server={0};uid={1};pwd={2};database={3}", new object[4]
            {
                (object) dbConfig.HostName,
                (object) dbConfig.UserId,
                (object) dbConfig.UserDbPassword,
                (object) dbConfig.DatabaseName
            });
        }
    }
}