using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

channel.ExchangeDeclare(
    exchange: "header-exchange-example",
    type: ExchangeType.Headers
);
Console.WriteLine("Lütfen Header Value'sunu giriniz: ");
string val = Console.ReadLine();

string queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(
    queueName,
    "header-exchange-example",
    routingKey: String.Empty,
    new Dictionary<string, object>
    {
        ["no"] = val
    }
    );

EventingBasicConsumer consumer = new(channel);

channel.BasicConsume(
    queueName,
    autoAck:true,
    consumer:consumer
    );

consumer.Received += (sender, e) =>
{
    string msg = Encoding.UTF8.GetString(e.Body.Span);
    Console.WriteLine(msg);
};

Console.Read();