
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
//    queueName, false, false, false
//);

//EventingBasicConsumer consumer = new(channel);
//channel.BasicConsume(
//    queue: queueName,
//    autoAck: false,
//    consumer: consumer
//    );

//consumer.Received += (sender, e) =>
//{
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));

//};

#endregion
#region Publish/Subscribe (Pub-Sub) Tasarımı

//string exchangeName = "example-pub-sub-exchange";

//channel.ExchangeDeclare(
//    exchange: exchangeName,
//    type: ExchangeType.Fanout
//);

//string queueName = channel.QueueDeclare().QueueName;

//channel.QueueBind(
//    queueName,
//    exchangeName,
//    String.Empty

//    );
//EventingBasicConsumer consumer = new(channel);
//channel.BasicConsume(
//    queue: queueName,
//    autoAck: false,
//    consumer: consumer
//    );

//consumer.Received += (sender, e) =>
//{
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));

//};

#endregion
#region Work Queue(İş Kuyruğu) Tasarımı

//string queueName = "example-work-queue";

//channel.QueueDeclare(queueName,false,false,false);
//EventingBasicConsumer consumer = new(channel);
//channel.BasicConsume(queue:queueName,autoAck:true,consumer: consumer);

//channel.BasicQos(prefetchCount:1,prefetchSize:0,global:false);

//consumer.Received += (sender, e) =>
//{;
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
//};

#endregion



#region Request/Response Tasarımı

string requestQueueName = "example-request-response-queue";

channel.QueueDeclare(requestQueueName, false,false,false);
EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(queue: requestQueueName, autoAck: true, consumer: consumer);


consumer.Received += (sender, e) =>
{
    
    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));

    byte[] responseMessage = Encoding.UTF8.GetBytes($"İşlem tamamlandı: {Encoding.UTF8.GetString(e.Body.Span)}");

    IBasicProperties properties = channel.CreateBasicProperties();
    properties.CorrelationId = e.BasicProperties.CorrelationId;
    channel.BasicPublish(
        exchange:String.Empty,
        routingKey:e.BasicProperties.ReplyTo,
        basicProperties:properties,
        body:responseMessage
        );
};

#endregion


Console.Read();
