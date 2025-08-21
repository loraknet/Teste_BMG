using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using TesteEdinaldo.Application.Wrappers;
using TesteEdinaldo.WebApi.Infrastructure.Extensions;

namespace TesteEdinaldo.WebApi.Endpoints
{
    public class DocEndpoint : EndpointGroupBase
    {
        public override void Map(RouteGroupBuilder builder)
        {
            builder.MapGet(GetErrorCodes);
        }

        Dictionary<string, string> GetErrorCodes()
        {
            return Enum.GetValues<ErrorCode>().ToDictionary(t => ((int)t).ToString(), t => t.ToString());
        }
    }
}
