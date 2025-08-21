using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs.Account.Requests;
using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
