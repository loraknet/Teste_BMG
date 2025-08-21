using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Interfaces.UserInterfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.Start
{
    public class StartCommandHandler(IAccountServices accountServices) : IRequestHandler<StartCommand, BaseResult<AuthenticationResponse>>
    {
        public async Task<BaseResult<AuthenticationResponse>> Handle(StartCommand request, CancellationToken cancellationToken = default)
        {
            var ghostUsername = await accountServices.RegisterGhostAccount();
            return await accountServices.AuthenticateByUserName(ghostUsername.Data);
        }
    }
}