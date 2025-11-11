
using Common.Models.Results;
using Common.Models.Users;

namespace Core.Interfaces.Users
{
    public interface IUsersServices
    {
        public Task<OperationResults<List<User>?>> GetAllUsers();
        public Task<OperationResults<User>?> GetUserById(int Id);

    }
}
