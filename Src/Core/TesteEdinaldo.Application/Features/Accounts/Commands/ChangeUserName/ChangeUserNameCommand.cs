using TesteEdinaldo.Application.DTOs.Account.Requests;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.ChangeUserName
{
    public class ChangeUserNameCommand : ChangeUserNameRequest, IRequest<BaseResult>
    {
    }
}