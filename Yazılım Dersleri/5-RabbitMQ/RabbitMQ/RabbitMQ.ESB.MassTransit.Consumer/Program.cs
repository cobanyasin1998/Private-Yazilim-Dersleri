

using MassTransit;
using RabbitMQ.ESB.MassTransit.Consumer.Consumers;

string rabbitMQUri = "amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric";

string queueName = "example-queue";

IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);
    factory.ReceiveEndpoint(
        queueName: queueName,
        endpoint =>
        {
            endpoint.Consumer<ExampleMessageConsumer>();
        });
});

await bus.StartAsync();

Console.ReadLine();