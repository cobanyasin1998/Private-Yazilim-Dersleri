

using MassTransit;
using RabbitMQ.ESB.MassTransit.Shared.RequestResponseMessages;

string rabbitMQUri = "amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric";
Console.WriteLine("Publisher");
IBusControl bus = Bus.Factory.CreateUsingRabbitMq(factory =>
{
    factory.Host(rabbitMQUri);
});

await bus.StartAsync();

var request = bus.CreateRequestClient<RequestMessage>(new Uri($"{rabbitMQUri}/request-queue"));


int i = 1;
while (true)
{
    await Task.Delay(200);
    var response = await request.GetResponse<ResponseMessage>(new()
    {
        MessageNo = i,
        Text = $"{++i}. request"
    });
    Console.WriteLine(response.Message.Text);
}
