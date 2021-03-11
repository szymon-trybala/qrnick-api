using System.Collections.Generic;
using System.Threading.Tasks;
using qrnick_api.Entities;

namespace qrnick_api.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByLoginAsync(string login);
    }
}