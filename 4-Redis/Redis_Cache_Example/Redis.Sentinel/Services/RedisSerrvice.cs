using StackExchange.Redis;

namespace Redis.Sentinel.Services
{
    public class RedisSerrvice
    {
        static ConfigurationOptions sentinelOptions => new()
        {
            EndPoints =
            {
                {"localhost",6383 },
                {"localhost",6384 },
                {"localhost",6385 },
            },
            CommandMap = CommandMap.Sentinel,
            AbortOnConnectFail = true
        };
        static ConfigurationOptions masterOptions => new()
        {
            AbortOnConnectFail = true
        };


        static public async Task<IDatabase> RedisMasterDatabase()
        {
            ConnectionMultiplexer sentinelConnection = await ConnectionMultiplexer.SentinelConnectAsync(sentinelOptions);
            System.Net.EndPoint masterEndPoint = null;
            foreach (System.Net.EndPoint endPoint in sentinelConnection.GetEndPoints())
            {
                IServer server = sentinelConnection.GetServer(endPoint);
                if (!server.IsConnected)
                {
                    continue;
                }
                else
                {
                    masterEndPoint = await server.SentinelGetMasterAddressByNameAsync("mymaster");
                    break;
                }
            }

            var localMasterIP = masterEndPoint.ToString() switch
            {
                "172.18.0.2:6379" => "localhost:6379",
                "172.18.0.3:6379" => "localhost:6380",
                "172.18.0.4:6379" => "localhost:6381",
                "172.18.0.5:6379" => "localhost:6382"
            };

            ConnectionMultiplexer masterConnection = await ConnectionMultiplexer.ConnectAsync(localMasterIP);

            IDatabase database = masterConnection.GetDatabase();
            return database;
        }
    }
}
/*
 BUNU .conf dosyasına yaz
 # Sentinel tarafından izlenecek Master sunucuları:
sentinel monitor mymaster 172.18.0.2 6379 3

# Master sunucunun tepki vermemesi durumunda Sentinel'in bekleme süresi:
sentinel down-after-milliseconds mymaster 5000

# Master sunucunun yeniden yapılandırılması için Sentinel'in beklemesi gereken süre:
sentinel failover-timeout mymaster 10000

# Sentinel tarafından eşzamanlı olarak kullanılacak slave sayısı:
sentinel parallel-syncs mymaster 3

 */

/*
  docker inspect --format='{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' $(docker ps -aq)
 */

/*
 
 docker run -d --name redis-sentinel-1 -p 6383:26379 --network redis-network -v c:\Users\coban\Desktop\sentinel.conf:/usr/local/etc/redis/sentinel.conf redis redis-sentinel /usr/local/etc/redis/sentinel.conf
 */



/*
  docker network create redis-network
 docker run -d --name redis-master -p 6379:6379 --network redis-network redis redis-server
 docker run -d --name redis-slave1 -p 6380:6379 --network redis-network redis redis-server --slaveof redis-master 6379
.
.
.

 */