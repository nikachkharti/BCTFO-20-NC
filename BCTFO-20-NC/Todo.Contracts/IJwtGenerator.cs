using Microsoft.AspNetCore.Identity;

namespace Todo.Contracts
{
    public interface IJwtGenerator
    {
        string GenerateToken(IdentityUser applicationUser, IEnumerable<string> roles);
    }
}
