using qrnick_api.Entities;

namespace qrnick_api.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser user);
    }
}