using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Features.Accounts.Commands.Authenticate;
using TesteEdinaldo.Application.Features.Accounts.Commands.ChangePassword;
using TesteEdinaldo.Application.Features.Accounts.Commands.ChangeUserName;
using TesteEdinaldo.Application.Features.Accounts.Commands.Start;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Wrappers;
using TesteEdinaldo.WebApi.Infrastructure.Extensions;

namespace TesteEdinaldo.WebApi.Endpoints
{
    public class AccountEndpoint : EndpointGroupBase
    {
        public override void Map(RouteGroupBuilder builder)
        {
            builder.MapPost(Authenticate);

            builder.MapPut(ChangeUserName).RequireAuthorization();

            builder.MapPut(ChangePassword).RequireAuthorization();

            builder.MapPost(Start);
        }

        async Task<BaseResult<AuthenticationResponse>> Authenticate(IMediator mediator, AuthenticateCommand model)
            => await mediator.Send<AuthenticateCommand, BaseResult<AuthenticationResponse>>(model);

        async Task<BaseResult> ChangeUserName(IMediator mediator, ChangeUserNameCommand model)
            => await mediator.Send<ChangeUserNameCommand, BaseResult>(model);

        async Task<BaseResult> ChangePassword(IMediator mediator, ChangePasswordCommand model)
            => await mediator.Send<ChangePasswordCommand, BaseResult>(model);

        async Task<BaseResult<AuthenticationResponse>> Start(IMediator mediator)
            => await mediator.Send<StartCommand, BaseResult<AuthenticationResponse>>(new StartCommand());

    }
}
