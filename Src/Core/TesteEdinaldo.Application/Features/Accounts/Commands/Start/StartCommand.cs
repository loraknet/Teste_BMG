using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.Start
{
    public class StartCommand : IRequest<BaseResult<AuthenticationResponse>>
    {
    }
}