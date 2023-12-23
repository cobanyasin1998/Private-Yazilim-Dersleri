


using MassTransit;
using RabbitMQ.ESB.MassTransit.Shared.Messages;

string rabbitMQUri = "amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric";

string queueName = "example-queue-2";

IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri, conf =>
    {
        conf.Username("gclmhric");
        conf.Password("ghEmFR2jAVVl7QB773LDPYRNgII5f3ad");
    });
});


ISendEndpoint sendEndpoint = 
    bus.GetSendEndpoint(new($"{rabbitMQUri}/{queueName}")).Result;


ExampleMessage data = new ExampleMessage()
{
    Text = "Hello"
};
try
{
    await sendEndpoint.Send<IMessage>(data);

}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}



Console.ReadLine();