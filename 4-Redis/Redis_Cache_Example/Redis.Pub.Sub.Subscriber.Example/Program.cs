


using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");


ISubscriber subscriber = connection.GetSubscriber();

subscriber.Subscribe("myChannel", (channel, message) =>
{
    Console.WriteLine($"Gelen Mesaj: {message}");
});
Console.ReadLine();

//kanal ismine myChannel.* yazarsam myChannel.1, myChannel.2 gibi kanalların hepsini dinler.