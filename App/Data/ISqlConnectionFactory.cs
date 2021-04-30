using ServiceStack.Redis;
using System.Data;

namespace Data
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
    public interface IRedisConnectionFactory
    {
        RedisClient GetOpenConnection();
    }
}
