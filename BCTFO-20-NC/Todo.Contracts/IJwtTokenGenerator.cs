using Microsoft.AspNetCore.Identity;

namespace Todo.Contracts
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(IdentityUser applicationUser, IEnumerable<string> roles);
    }
}
