
using MassTransit;
using RabbitMQ.ESB.MassTransit.WorkerService.Consumer.Consumers;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddMassTransit(conf =>
        {
            conf.AddConsumer<ExampleMessageConsumer>();
            conf.UsingRabbitMq((context, _conf) =>
            {
                _conf.Host("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");

                _conf.ReceiveEndpoint("example-message-queue", e => e.ConfigureConsumer<ExampleMessageConsumer>(context));
            });
        });
    })
    .Build();

await host.RunAsync();
