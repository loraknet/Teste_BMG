using System.Threading;
using System.Threading.Tasks;
using TesteEdinaldo.Application.Interfaces;
using TesteEdinaldo.Application.Interfaces.UserInterfaces;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Features.Accounts.Commands.ChangePassword
{
    public class ChangePasswordCommandHandler(IAccountServices accountServices) : IRequestHandler<ChangePasswordCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(ChangePasswordCommand request, CancellationToken cancellationToken = default)
        {
            return await accountServices.ChangePassword(request);
        }
    }
}