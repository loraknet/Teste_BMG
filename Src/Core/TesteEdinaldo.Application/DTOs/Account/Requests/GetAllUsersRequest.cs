using TesteEdinaldo.Application.Parameters;

namespace TesteEdinaldo.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
