

//using Grpc.Net.Client;

using Google.Protobuf;
using Grpc.Core;
using Grpc.Net.Client;
using grpcMessageServer;
using grpcServer;

var channel = GrpcChannel.ForAddress("https://localhost:7191");
//var client = new Greeter.GreeterClient(channel);
//var reply = await client.SayHelloAsync(
//                 new HelloRequest { 
//                     Name = "GreeterClient" 
//                 });
//Console.WriteLine("Greeting: " + reply.Message);

//Unary call
//var client = new Message.MessageClient(channel);
//var reply = await client.SendMessageAsync(
//                    new MessageRequest
//                    {
//                        Name = "MessageClient",
//                        Message = "Hello from MessageClient"
//                    });
//Console.WriteLine("Message: " + reply.Message);


//Server streaming
var client = new Message.MessageClient(channel);
var cts = new CancellationTokenSource();
using var call = client.SendMessage(
                       new MessageRequest
                       {
                           Name = "MessageClient",
                           Message = "Hello from MessageClient"
                       }, cancellationToken: cts.Token);

while (await call.ResponseStream.MoveNext(cts.Token))
{

    Console.WriteLine(call.ResponseStream.Current.Message);
}

Console.ReadLine();