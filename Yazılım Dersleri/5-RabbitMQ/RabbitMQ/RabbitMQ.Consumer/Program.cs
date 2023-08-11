using RabbitMQ.Client;

using RabbitMQ.Client.Events;
using System.Text;

//Bağlantı Oluşturma
ConnectionFactory factory = new ConnectionFactory();

factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");
//Bağlantı Aktifleştirme ve Kanal Açma
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

//Queue Oluşturma

channel.QueueDeclare("example-queue", exclusive: false, autoDelete: false);


//Queue'dan Mesaj Okuma

EventingBasicConsumer consumer = new(channel);
channel.BasicConsume(queue: "example-queue", false, consumer);

consumer.Received += (sender, e) =>
{
    //Kuyruğa gelen mesajin işlendiği yerdir
    //e.Body : Kuyruktaki mesajın verisini bütünsel olarak getirir. ToArray yerisine Span da kullanılabilir.

    var message = Encoding.UTF8.GetString(e.Body.ToArray());
    Console.WriteLine(message);
    channel.BasicAck(e.DeliveryTag, multiple: false);
    //channel.BasicNack(e.DeliveryTag, multiple: false, requeue: true);

};

Console.Read();