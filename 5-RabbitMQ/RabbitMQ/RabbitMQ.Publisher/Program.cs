using RabbitMQ.Client;
using System.Text;
//Bağlantı Oluşturma
ConnectionFactory factory = new();
factory.Uri = new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");

//Bağlantıyı Aktifleştirme ve Kanal Açma
using IConnection connection = factory.CreateConnection();
IModel channel = connection.CreateModel();

//Queue Oluşturma
channel.QueueDeclare("example-queue", exclusive: false, autoDelete: false, durable: true);

//Queue'ya Mesaj Gönderme
//RabbitMQ kuyruğa atacağı mesajları byte türünden kabul etmektedir. Haliyle mesajları byte'a dönüştürmemiz gerekecektir.

byte[] message = Encoding.UTF8.GetBytes("Merhaba");
IBasicProperties properties = channel.CreateBasicProperties();
properties.Persistent = true;
for (int i = 0; i < 100; i++)
{
    await Task.Delay(2000);
    channel.BasicPublish(exchange: "", "example-queue", body: message, basicProperties: properties);
}


Console.Read();