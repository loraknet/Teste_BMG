using Microsoft.AspNetCore.Identity;
using System;

namespace TesteEdinaldo.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
