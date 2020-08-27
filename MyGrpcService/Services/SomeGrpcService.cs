using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MyGrpcServiceProtos;

namespace MyGrpcService.Services 
{
    public class SomeGrpcService : SomeService.SomeServiceBase
    {
        public override Task<SomeModel> getSomeItem(Empty request, ServerCallContext context)
        {
            return Task.FromResult(GetSomeData());
        }

        private SomeModel GetSomeData()
        {
            return new SomeModel()
            {
                Name = "Geronimo",
                Description = "I call it Geronimo"
            };
        }
    }
}
