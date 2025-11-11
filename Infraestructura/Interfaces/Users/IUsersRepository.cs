using Common.Models.Users;

namespace Infraestructura.Interfaces.Users
{
    public interface IUsersRepository
    {
        Task<List<User>?> GetAllUsers();
    }
}
