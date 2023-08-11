using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

channel.ExchangeDeclare(
    exchange: "header-exchange-example",
    type: ExchangeType.Headers
    );

for (int i = 0; i < 100; i++)
{
    await Task.Delay(200);
    byte[] message = Encoding.UTF8.GetBytes($"Merhaba {i}");
    Console.WriteLine("Lütfen Header Value'sunu giriniz: ");

    string val = Console.ReadLine();

    IBasicProperties properties = channel.CreateBasicProperties();
    properties.Headers = new Dictionary<string, object>
    {
        ["no"] = val
    };

    channel.BasicPublish(
        exchange: "header-exchange-example",
        routingKey: String.Empty,
        body: message,
        basicProperties: properties
        );
}


Console.Read();