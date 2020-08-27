using System;

namespace MyGrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = Grpc.Net.Client.GrpcChannel.ForAddress("https://localhost:5001/");

            var client = new MyGrpcServiceProtos.SomeService.SomeServiceClient(channel);
            var request = new Google.Protobuf.WellKnownTypes.Empty();
            var result = client.getSomeItem(request);
            Console.WriteLine(result.Name);
            Console.WriteLine(result.Description);
            Console.ReadKey();
        }
    }
}
