using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


channel.ExchangeDeclare(
    exchange: "direct-exchange-example",
    type: ExchangeType.Direct);

string queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(
    queue: queueName,
    exchange: "direct-exchange-example",
   routingKey: "direct-queue-example");

EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(queueName, true, consumer: consumer);

consumer.Received += (sender, e) =>
{

    string message = Encoding.UTF8.GetString(e.Body.Span);
    Console.WriteLine(message);
};

Console.Read();