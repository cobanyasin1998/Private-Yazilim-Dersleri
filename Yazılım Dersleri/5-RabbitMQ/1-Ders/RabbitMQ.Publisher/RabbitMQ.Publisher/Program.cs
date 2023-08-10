

using RabbitMQ.Client;
//Bağlantı Oluşturma
ConnectionFactory factory = new();
factory.Uri =new("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");

//Bağlantıyı Aktifleştirme ve Kanal Açma
using IConnection connection = factory.CreateConnection();
IModel channel= connection.CreateModel();

//Queue Oluşturma
channel.QueueDeclare("example-queue");

