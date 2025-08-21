using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Interfaces.UserInterfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.Authenticate
{
    public class AuthenticateCommandHandler(IAccountServices accountServices) : IRequestHandler<AuthenticateCommand, BaseResult<AuthenticationResponse>>
    {
        public async Task<BaseResult<AuthenticationResponse>> Handle(AuthenticateCommand request, CancellationToken cancellationToken = default)
        {
            return await accountServices.Authenticate(request);
        }
    }
}