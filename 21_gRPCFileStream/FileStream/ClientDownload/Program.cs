

using Grpc.Net.Client;
using grpcFileTransportClient;


class Program
{
    static async Task Main(string[] args)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:7002");
        var client = new FileService.FileServiceClient(channel);

        string downloadFile = "D:\\Yazilim\\Private-Yazilim-Dersleri\\21_gRPCFileStream\\FileStream\\ClientDownload\\DownloadFiles";

        var fileInfo = new grpcFileTransportClient.FileInfo
        {
            FileName = "deneme",
            FileExtension = ".dll"
        };

        FileStream fileStream = null;

        var request = client.FileDownload(fileInfo);

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        int count = 0;
        decimal chunkSize = 0;

        while (await request.ResponseStream.MoveNext(cancellationTokenSource.Token))
        {
            if (count++ == 0)
            {
                fileStream = new FileStream(@$"{downloadFile}\{request.ResponseStream.Current.Info.FileName}{request.ResponseStream.Current.Info.FileExtension}", FileMode.CreateNew);
                fileStream.SetLength(request.ResponseStream.Current.FileSize);
            }
            var buffer = request.ResponseStream.Current.Buffer.ToByteArray();
            await fileStream.WriteAsync(buffer, 0, request.ResponseStream.Current.ReadedByte);

            Console.WriteLine($"Downloaded: {Math.Round(((chunkSize += request.ResponseStream.Current.ReadedByte) * 100) / request.ResponseStream.Current.FileSize)} %");
        }

        Console.WriteLine("Downloaded");
        await fileStream.DisposeAsync();
        fileStream.Close();
    }

}