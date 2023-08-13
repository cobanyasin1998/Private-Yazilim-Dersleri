

using MassTransit;
using RabbitMQ.ESB.MassTransit.RequestResponsePattern.Consumer.Consumers;

string rabbitMQUri = "amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric";
Console.WriteLine("Consumer");

IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);

    factory.ReceiveEndpoint("request-queue", conf =>
    {
        conf.Consumer<RequestMessageConsumer>();
    });
});

await bus.StartAsync();



Console.Read();