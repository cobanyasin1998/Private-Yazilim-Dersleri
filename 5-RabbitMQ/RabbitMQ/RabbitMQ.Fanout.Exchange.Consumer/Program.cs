using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

channel.ExchangeDeclare(
    exchange: "fanout-exchange-example",
    type: ExchangeType.Fanout);

Console.Write("Kuyruk Adını Giriniz: ");
string _queueName = Console.ReadLine();

channel.QueueDeclare(
    queue: _queueName,
    exclusive: false);

channel.QueueBind(
    queue: _queueName,
    exchange: "fanout-exchange-example",
    routingKey: String.Empty);

EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(
    queue: _queueName,
    autoAck: true,
    consumer: consumer);

consumer.Received += (sender, e) =>
{
    String message = Encoding.UTF8.GetString(e.Body.Span);
    Console.WriteLine(message);
};

Console.Read();