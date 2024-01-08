
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using grpcFileTransportServer;
using static grpcFileTransportServer.FileService;

namespace Server.Services
{
    public class FileTransportService : FileService.FileServiceBase
    {
        readonly IWebHostEnvironment _webHostEnvironment;
        public FileTransportService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public override async Task<Empty> FileUpload(IAsyncStreamReader<BytesContent> requestStream, ServerCallContext context)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Files");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileStream fs = null;
            try
            {
                int count = 0;
                decimal chunkSize = 0;
                while (await requestStream.MoveNext())
                {
                    if (count++ == 0)
                    {
                        fs = new FileStream($"{path}/{requestStream.Current.Info.FileName}{requestStream.Current.Info.FileExtension}", FileMode.CreateNew);
                        fs.SetLength(requestStream.Current.FileSize);
                    }
                    var buffer = requestStream.Current.Buffer.ToByteArray();
                    await fs.WriteAsync(buffer, 0, buffer.Length);

                    Console.WriteLine($"{Math.Round(((chunkSize += requestStream.Current.ReadedByte) * 100) / requestStream.Current.FileSize)} %");
                }
            }
            catch (Exception)
            {
                //Log
            }
            await fs.DisposeAsync();
            fs.Close();
            return new Empty();
        }

        public override async Task FileDownload(grpcFileTransportServer.FileInfo request, IServerStreamWriter<BytesContent> responseStream, ServerCallContext context)
        {

            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Files");
            FileStream fs = new FileStream($"{path}/{request.FileName}{request.FileExtension}", FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[2048];

            BytesContent bytesContent = new BytesContent()
            {
                FileSize = fs.Length,
                Info = new grpcFileTransportServer.FileInfo()
                {
                    FileName = Path.GetFileNameWithoutExtension(fs.Name),
                    FileExtension = Path.GetExtension(fs.Name)
                },
                ReadedByte = 0
            };

            while ((bytesContent.ReadedByte = await fs.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                bytesContent.Buffer = ByteString.CopyFrom(buffer);
                await responseStream.WriteAsync(bytesContent);

            }
            fs.Close();
        }
    }
}
