using MassTransit;
using RabbitMQ.ESB.MassTransit.WorkerService.Publisher;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddMassTransit(conf =>
        {
            conf.UsingRabbitMq((context, _conf) =>
            {
                _conf.Host("amqps://gclmhric:ghEmFR2jAVVl7QB773LDPYRNgII5f3ad@toad.rmq.cloudamqp.com/gclmhric");

            });
        });
        services.AddHostedService<PublishMessageService>(provider =>
        {
            using IServiceScope scope = provider.CreateScope();
            IPublishEndpoint publishEndpoint = scope.ServiceProvider.GetService<IPublishEndpoint>();
            return new(publishEndpoint);

        });
    })
    .Build();

await host.RunAsync();