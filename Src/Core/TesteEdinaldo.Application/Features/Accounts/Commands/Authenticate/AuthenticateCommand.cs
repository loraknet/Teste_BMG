using TesteEdinaldo.Application.DTOs.Account.Requests;
using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.Authenticate
{
    public class AuthenticateCommand : AuthenticationRequest, IRequest<BaseResult<AuthenticationResponse>>
    {
    }
}