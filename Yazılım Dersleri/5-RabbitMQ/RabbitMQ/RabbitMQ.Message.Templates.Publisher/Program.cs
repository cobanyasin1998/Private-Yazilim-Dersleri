﻿
using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


#region P2P (Point-to-Point) Tasarımı

//string queueName = "example-p2p-queue";

//channel.QueueDeclare(
//    queueName, false, false,false
//);

//byte[] message = Encoding.UTF8.GetBytes("Merhaba");

//channel.BasicPublish(
//    exchange: String.Empty, 
//    queueName, 
//    body: message
//    );


#endregion
#region Publish/Subscribe (Pub-Sub) Tasarımı

//string exchangeName = "example-pub-sub-exchange";

//channel.ExchangeDeclare(
//    exchange: exchangeName,
//    type: ExchangeType.Fanout
//    );
//for (int i = 0; i < 100; i++)
//{
//    byte[] message = Encoding.UTF8.GetBytes($"Merhaba {i}");
//    channel.BasicPublish(
//        exchange: exchangeName,
//        routingKey: String.Empty,
//        body: message);
//}
#endregion
#region Work Queue(İş Kuyruğu) Tasarımı

//string queueName = "example-work-queue";
//channel.QueueDeclare(queueName,false,false,false);

//for (int i = 0; i < 100; i++)
//{
//    await Task.Delay(200);

//    byte[] message = Encoding.UTF8.GetBytes($"Merhaba {i}");

//    channel.BasicPublish(exchange:String.Empty, routingKey:queueName,body:message);

//}

#endregion
#region Request/Response Tasarımı

string requestQueueName = "example-request-response-queue";
channel.QueueDeclare(
    queue: requestQueueName,
    durable: false,
    exclusive: false,
    autoDelete: false
    );

string replyQueueName = channel.QueueDeclare().QueueName;
string correlationId = Guid.NewGuid().ToString();

#region Request Mesajını Oluşturma ve Gönderme

IBasicProperties properties = channel.CreateBasicProperties();
properties.CorrelationId = correlationId;
properties.ReplyTo = replyQueueName;

for (int i = 0; i < 10; i++)
{
    byte[] message = Encoding.UTF8.GetBytes($"Merhaba {i}");
    channel.BasicPublish(exchange:String.Empty,routingKey:requestQueueName,
         body:message,basicProperties:properties);
}

#endregion
#region Response Kuyruğu Dinleme

EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(queue:replyQueueName,autoAck:true,consumer:consumer);

consumer.Received += (sender, e) =>
{
    if (e.BasicProperties.CorrelationId == correlationId)
    {
        Console.WriteLine($"Response: {Encoding.UTF8.GetString(e.Body.Span)}");
    }
};

#endregion

#endregion

Console.Read();