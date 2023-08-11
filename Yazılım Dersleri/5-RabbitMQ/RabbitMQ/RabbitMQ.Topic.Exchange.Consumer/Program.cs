using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

channel.ExchangeDeclare(
    exchange: "topic-exchange-example",
    type: ExchangeType.Topic
);


Console.WriteLine("Dinlenecek Topic Formatını Belirtiniz: ");

string topic = Console.ReadLine();
string queueName = channel.QueueDeclare().QueueName;

channel.QueueBind(
    
    queueName,
    "topic-exchange-example",
    routingKey:topic);

EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(
    queueName,true,consumer
    );

consumer.Received += (sender, e) =>
{
    string msg = Encoding.UTF8.GetString(e.Body.Span);
    Console.WriteLine(msg);

};

Console.Read();