using System.Threading.Tasks;
using TesteEdinaldo.Application.DTOs.Account.Requests;
using TesteEdinaldo.Application.DTOs.Account.Responses;
using TesteEdinaldo.Application.Wrappers;

namespace TesteEdinaldo.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
