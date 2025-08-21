using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Interfaces.UserInterfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.ChangeUserName
{
    public class ChangeUserNameCommandHandler(IAccountServices accountServices) : IRequestHandler<ChangeUserNameCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(ChangeUserNameCommand request, CancellationToken cancellationToken = default)
        {
            return await accountServices.ChangeUserName(request);
        }
    }
}